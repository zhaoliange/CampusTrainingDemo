using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewsDemo.Models;
using ViewsDemo.ViewModels;

namespace ViewsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            var viewModel = new Address()
            {
                Name = "Microsoft",
                Street = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                PostalCode = "98052-6399"
            };

            return View(viewModel);
        }

        public IActionResult ViewDataDemo()
        {
            ViewData["Greeting"] = "Hello";
            ViewData["Address"] = new Address()
            {
                Name = "Steve",
                Street = "123 Main St",
                City = "Hudson",
                State = "OH",
                PostalCode = "44236"
            };

            return View();
        }

        public IActionResult ViewBagDemo()
        {
            ViewBag.Greeting = "Hello";
            
            ViewBag.Address = new Address()
            {
                Name = "Steve",
                Street = "123 Main St",
                City = "Hudson",
                State = "OH",
                PostalCode = "44236"
            };
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}