using _413_Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _413_Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> rauntList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                rauntList.Add($"#{r.rank}: {r.name}, location: {r.address}, Favorite Dish: {r.favDish}, Phone#: {r.phoneNum}, Website: {r.website}");
            }

            return View(rauntList);
        }

        [HttpGet]
        public IActionResult Suggest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggest(Suggestion appResponse)
        {
            Regex reg = new Regex(@"^([\+][0-9]{1,3}([ \.\-])?)?([\(]{1}[0-9]{3}[\)])?([0-9A-Z \.\-]{1,32})((x|ext|extension)?[0-9]{1,4}?)$");

            //Validate the model
            while (true)
            {
                if (ModelState.IsValid)
                {
                


                    if (!reg.IsMatch(appResponse.Phone))
                    {
                        break;
                    }
                    TempStorage.AddApplication(appResponse);
                    return View("SubmittedForm", appResponse);
                }
            }

            //List out the Validation Errors
            return View();
 
        }

        public IActionResult proposedRaunts()
        {
            return View(TempStorage.Suggestions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
