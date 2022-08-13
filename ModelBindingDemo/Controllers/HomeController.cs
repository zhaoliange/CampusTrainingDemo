using Microsoft.AspNetCore.Mvc;
using ModelBindingDemo.Models;
using System.Diagnostics;

namespace ModelBindingDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult FirstSample(

            [FromHeader] string header,

            [FromForm] string form,

            [FromRoute] string id,

            [FromQuery] string query)

        {

            return Content($"header: {header}, form: {form}, id: {id}, query: {query}");

        }


        public IActionResult DISample([FromServices] ILogger<HomeController> logger)

        {

            return Content($"logger is null: {logger == null}.");

        }



        public IActionResult BodySample([FromBody] UserModel model)

        {

            return Ok(model);

        }
    }
}