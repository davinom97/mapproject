using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WikiMaps.Models;

namespace WikiMaps.Controllers
{
    public class HomeController : Controller
    {

       
        public IActionResult Index()
        {
            //var coords = new List<CoordsModel>();
            Console.Write("swag1");
            Console.WriteLine("swag2");
            CoordsMapper coords = new CoordsMapper();   
            ViewBag.coordslist = coords.mapcoords();
            return View();
        }

        [HttpPost]
        public IActionResult Index(string test)
        {
            Console.Write("ya yeet"+test);
            CoordsMapper coords = new CoordsMapper();
            ViewBag.coordslist = coords.mapcoords();
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
