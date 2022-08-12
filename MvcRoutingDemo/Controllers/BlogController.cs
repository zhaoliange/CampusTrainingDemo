using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingDemo.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Article()
        {
            
            return View();
        }
    }
}
