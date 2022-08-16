using Microsoft.AspNetCore.Mvc;
using MvcRoutingDemo.Models;
using System.Diagnostics;
using Microsoft.Docs.Samples;

namespace MvcRoutingDemo.Controllers
{
    // Attribute routing

    //[Route("[controller]/[action]")]
    //[Route("Home")]
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

        /*
        [Route("")]
        [Route("Home")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        [Route("[controller]/[action]")]
        public IActionResult About()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }
        */
        /*
        [Route("~/")]
        [Route("/Home")]
        [Route("~/Home/Index")]
        public IActionResult Index()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        public IActionResult About()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }
        */
        /*
        [Route("")]
        [Route("Index")]
        [Route("/")]
        public IActionResult Index()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        [Route("About")]
        public IActionResult About()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }
        */
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