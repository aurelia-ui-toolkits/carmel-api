using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Carmel.Controllers.Web
{
  public class AppController : Controller
  {
    private IConfigurationRoot _config;

    public AppController(IConfigurationRoot config)
    {
      _config = config;
    }

    public IActionResult Index()
    {
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
