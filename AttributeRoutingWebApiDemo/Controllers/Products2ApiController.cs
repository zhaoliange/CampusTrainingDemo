using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace AttributeRoutingWebApiDemo.Controllers
{
    //Route name

    [ApiController]
    public class Products2ApiController : ControllerBase
    {
        [HttpGet("/products2/{id}", Name = "Products_List")]
        public IActionResult GetProduct(int id)
        {
            return ControllerContext.MyDisplayRouteInfo(id);
        }
    }
}
