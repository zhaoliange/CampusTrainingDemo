using Microsoft.AspNetCore.Mvc;
using MvcRoutingDemo.Models;
using System.Diagnostics;
using Microsoft.Docs.Samples;

namespace MvcRoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Index/{id?}")]
        public IActionResult Index(int? id)
        {
            return ControllerContext.MyDisplayRouteInfo(id);
        }

        [Route("Home/About")]
        [Route("Home/About/{id?}")]
        public IActionResult About(int? id)
        {
            return ControllerContext.MyDisplayRouteInfo(id);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}