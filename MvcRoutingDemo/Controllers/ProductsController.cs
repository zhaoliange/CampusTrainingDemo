using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace MvcRoutingDemo.Controllers
{
    //Set up conventional route
    public class ProductsController : Controller
    {
        public IActionResult Details(int id)
        {
            return ControllerContext.MyDisplayRouteInfo(id);
        }
    }
}
