using Microsoft.AspNetCore.Mvc;
using ModelBindingDemo.Models;
using ModelValidationDemo.Models;
using System.Diagnostics;

namespace ModelValidationDemo.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult BodySample([FromBody] UserModel model)

        {

            // 由于 Id 是 int 类型，int 默认为 0

            // 虽然带上了 [Required]，但不是 null 所以算是有值。

            if (model.Id < 1)

            {

                ModelState.AddModelError("Id", "Id not exist");

            }

            if (ModelState.IsValid)

            {

                return Ok(model);

            }

            return BadRequest(ModelState);

        }
    }
}