using IntroToWebApps5.Core5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToWebApps5.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            ViewData["Message"] = "Your application processed some data.";
            // read more on ViewDataAttributes as homework ;)

            if (person == null || !ModelState.IsValid)
            {
                Person invalidPerson = new Person
                {
                    FirstName = "Invalid"
                };
                return View(invalidPerson);
            }
            return View(person);
        }
    }
}
