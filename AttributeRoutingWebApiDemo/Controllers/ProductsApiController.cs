using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace AttributeRoutingWebApiDemo.Controllers
{
    //Combining attribute routes

    [ApiController]
    [Route("products")]
    public class ProductsApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListProducts()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return ControllerContext.MyDisplayRouteInfo(id);
        }
    }
}
