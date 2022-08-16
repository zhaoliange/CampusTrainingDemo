using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace MvcRoutingDemo.Controllers
{
    //Reserved routing names
    public class MyDemo2Controller : Controller
    {
        [Route("/articles/{page}")]
        public IActionResult ListArticles(int page)
        {
            return ControllerContext.MyDisplayRouteInfo(page);
        }
    }
}
