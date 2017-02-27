using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Carmel.Models;
using System.Linq;

namespace Carmel.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _config;
        private ICatalogRepository _repository;

        public AppController(IConfigurationRoot config, ICatalogRepository repository)
        {
            _config = config;
            _repository = repository;
        }

        public IActionResult Index()
        {
            var components = _repository.GetAllComponents();
            return View(components);
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
