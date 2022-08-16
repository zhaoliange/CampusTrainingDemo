using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using MvcRoutingDemo.Models;

namespace MvcRoutingDemo.Controllers
{
    public class Products33Controller : Controller
    {
        //Resolving ambiguous actions
        public IActionResult Edit(int id)
        {
            return ControllerContext.MyDisplayRouteInfo(id);
        }

        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            return ControllerContext.MyDisplayRouteInfo(id, product.name);
        }
    }
}
