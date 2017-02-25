using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Carmel.Models;
using System.Linq;

namespace Carmel.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _config;
        private CatalogContext _context;

        public AppController(IConfigurationRoot config, CatalogContext context)
        {
            _config = config;
            _context = context;
        }

        public IActionResult Index()
        {
            var components = _context.Components.OrderBy(c => c.Name).ToList();
            return View();
        }

        public IActionResult Generator()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
