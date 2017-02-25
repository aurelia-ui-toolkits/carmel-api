using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Carmel.Models
{

    public class CatalogContext : DbContext
    {
        private IConfigurationRoot _config;

        public CatalogContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;

            Database.EnsureCreated();
        }

        public DbSet<Component> Components { get; set; }
        public DbSet<Sample> Samples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Server=(localdb)\\MSSQLLocalDb;Database=CarmelDb;Trusted_Connection=true;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
