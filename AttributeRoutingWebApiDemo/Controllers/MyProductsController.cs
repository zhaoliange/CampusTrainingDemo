using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace AttributeRoutingWebApiDemo.Controllers
{
    //two actions that match the same route template

    [ApiController]
    public class MyProductsController : ControllerBase
    {
        [HttpGet("/products3")]
        public IActionResult ListProducts()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        [HttpPost("/products3")]
        public IActionResult CreateProduct(MyProduct myProduct)
        {
            return ControllerContext.MyDisplayRouteInfo(myProduct.Name);
        }
    }
}
