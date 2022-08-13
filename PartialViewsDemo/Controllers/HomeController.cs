using Microsoft.AspNetCore.Mvc;
using PartialViewsDemo.Models;
using System.Diagnostics;

namespace PartialViewsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)

        {

            return View(new List<UserModel>()

        {

            new UserModel()

            {

                Id = 1,

                Name = "John",

                Email = "john@xxx.xxx",

            },

            new UserModel()

            {

                Id = 2,

                Name = "Blackie",

                Email = "blackie@xxx.xxx"

            },

            new UserModel()

            {

                Id = 3,

                Name = "Claire",

                Email = "claire@xxx.xxx"

            }

        });
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