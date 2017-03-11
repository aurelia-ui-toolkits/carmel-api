using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Carmel.Models;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json.Serialization;
using AutoMapper;
using Carmel.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using System.Threading.Tasks;
using System;

namespace Carmel
{
    public class Startup
    {
        private IHostingEnvironment _env;
        private IConfigurationRoot _config;

        public Startup(IHostingEnvironment env)
        {
            _env = env;

            var builder = new ConfigurationBuilder()
              .SetBasePath(_env.ContentRootPath)
              .AddJsonFile("config.json")
			  .AddJsonFile("appsettings.json")
              .AddEnvironmentVariables();

            _config = builder.Build();
        }

        public IConfigurationRoot Configuration {
			get {
				return _config;
			}
		}

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_config);

            // Add authentication services
            services.AddAuthentication(
                options => options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme);

            services.AddMvc()
                .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });

            services.AddLogging();

            services.AddEntityFrameworkSqlServer().AddDbContext<CatalogContext>();

            services.AddTransient<CatalogContextSeedData>();

            services.AddScoped<ICatalogRepository, CatalogRepository>();

            // Add functionality to inject IOptions<T>
            services.AddOptions();

            // Add the Auth0 Settings object so it can be injected
            services.Configure<Auth0Settings>(Configuration.GetSection("Auth0"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, CatalogContextSeedData seeder, ILoggerFactory loggerFactory, IOptions<Auth0Settings> auth0Settings)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

            loggerFactory.AddDebug(LogLevel.Warning);

            app.UseStaticFiles();

            // Add the cookie middleware
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AutomaticAuthenticate = true,
                AutomaticChallenge = true
            });

            var options = new OpenIdConnectOptions("Auth0")
            {
                // Set the authority to your Auth0 domain
                Authority = $"https://{auth0Settings.Value.Domain}",

                // Configure the Auth0 Client ID and Client Secret
                ClientId = auth0Settings.Value.ClientId,
                ClientSecret = auth0Settings.Value.ClientSecret,

                // Do not automatically authenticate and challenge
                AutomaticAuthenticate = false,
                AutomaticChallenge = false,

                // Set response type to code
                ResponseType = "code",

                // Set the callback path, so Auth0 will call back to http://localhost:8000/signin-auth0 
                // Also ensure that you have added the URL as an Allowed Callback URL in your Auth0 dashboard 
                CallbackPath = new PathString("/signin-auth0"),

                // Configure the Claims Issuer to be Auth0
                ClaimsIssuer = "Auth0",

                Events = new OpenIdConnectEvents
                {
                    // handle the logout redirection 
                    OnRedirectToIdentityProviderForSignOut = (context) =>
                    {
                        var logoutUri = $"https://{auth0Settings.Value.Domain}/v2/logout?client_id={auth0Settings.Value.ClientId}";

                        var postLogoutUri = context.Properties.RedirectUri;
                        if (!string.IsNullOrEmpty(postLogoutUri))
                        {
                            if (postLogoutUri.StartsWith("/"))
                            {
                                // transform to absolute
                                var request = context.Request;
                                postLogoutUri = request.Scheme + "://" + request.Host + request.PathBase + postLogoutUri;
                            }
                            logoutUri += $"&returnTo={ Uri.EscapeDataString(postLogoutUri)}";
                        }

                        context.Response.Redirect(logoutUri);
                        context.HandleResponse();

                        return Task.CompletedTask;
                    }
                }
            };
            options.Scope.Clear();
            options.Scope.Add("openid");
            app.UseOpenIdConnectAuthentication(options);

            Mapper.Initialize(config =>
            {
                config.CreateMap<Component, ComponentViewModel>().ReverseMap();
                config.CreateMap<Sample, SampleViewModel>().ReverseMap();
            });

            app.UseMvc(config =>
            {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "Index" }
                );
            });

            //
            // This gets called only at server startup and only of the database does not exist
            seeder.CreateSeedData();
        }
    }
}
