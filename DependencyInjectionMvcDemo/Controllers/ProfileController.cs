using DependencyInjectionMvcDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionMvcDemo.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            // A real app would up profile based on the user.
            var profile = new Profile()
            {
                Name = "Rick",
                FavColor = "Blue",
                Gender = "Male",
                State = new State("Ohio", "OH")
            };
            return View(profile);
        }
    }
}
