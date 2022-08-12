﻿using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDateTime _dateTime;

        public HomeController(IDateTime dateTime)
        {
            _dateTime = dateTime;
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            var serverTime = _dateTime.Now;
            if (serverTime.Hour < 12)
            {
                ViewData["Message"] = "It's morning here - Good Morning!";
            }
            else if (serverTime.Hour < 17)
            {
                ViewData["Message"] = "It's afternoon here - Good Afternoon!";
            }
            else
            {
                ViewData["Message"] = "It's evening here - Good Evening!";
            }
            return View();
        }
        public IActionResult About([FromServices] IDateTime dateTime)
        {
            return Content($"Current server time: {dateTime.Now}");
        }
    }
}
