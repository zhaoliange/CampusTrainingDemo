using FiltersDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FiltersDemo.Controllers
{
    //[ServiceFilter(typeof(SampleActionFilter))]
    //[SampleActionFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [TypeFilter(typeof(SampleActionFilter))]
        public IActionResult Index()
        {
            Console.WriteLine(
            $"- {nameof(HomeController)}.{nameof(Index)}");
            return View();
        }

        public IActionResult Privacy()
        {
            Console.WriteLine(
           $"- {nameof(HomeController)}.{nameof(Privacy)}");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}