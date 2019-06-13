using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Select2_MultiSelect.Models;

namespace Select2_MultiSelect.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Automobile> autos = new List<Automobile>();
            Automobile auto = GetAuto(1, "Chevy");
            autos.Add(auto);
            auto = GetAuto(2, "Ford");
            autos.Add(auto);
            auto = GetAuto(3, "Audi");
            autos.Add(auto);
            auto = GetAuto(4, "Toyota");
            autos.Add(auto);
            auto = GetAuto(5, "Duster");
            autos.Add(auto);
            auto = GetAuto(6, "Esteem");
            autos.Add(auto);
            auto = GetAuto(7, "Fiero");
            autos.Add(auto);
            auto = GetAuto(8, "Lancer");
            autos.Add(auto);
            auto = GetAuto(9, "Phantom");
            autos.Add(auto);
            Dealership dealership = new Dealership { Automobiles = autos };
            return View(dealership);
        }
        [HttpPost]
        public ActionResult Index(Dealership dealer)
        {
            List<Automobile> autos = new List<Automobile>();
            Automobile auto = GetAuto(1, "Chevy");
            autos.Add(auto);
            auto = GetAuto(2, "Ford");
            autos.Add(auto);
            auto = GetAuto(3, "Audi");
            autos.Add(auto);
            auto = GetAuto(4, "Toyota");
            autos.Add(auto);
            auto = GetAuto(5, "Duster");
            autos.Add(auto);
            auto = GetAuto(6, "Esteem");
            autos.Add(auto);
            auto = GetAuto(7, "Fiero");
            autos.Add(auto);
            auto = GetAuto(8, "Lancer");
            autos.Add(auto);
            auto = GetAuto(9, "Phantom");
            autos.Add(auto);
            Dealership dealership = new Dealership { Automobiles = autos ,
                SelectedAutomobiles = dealer.SelectedAutomobiles
            };
            //    Dealership dealership = new Dealership { SelectedAutomobiles = dealer.SelectedAutomobiles };
            return View(dealership);
        }

        private static Automobile GetAuto(int id, string make)
        {
            return new Automobile { Id = id, Make = make };
        }

        [HttpPost]
        public JsonResult GetAnswer(string question)
        {
            int index = _rnd.Next(_db.Count);
            var answer = _db[index];
            return Json(answer);
        }

        private static Random _rnd = new Random();
        private static List<string> _db = new List<string> { "Yes", "No", "Definitely, yes", "I don't know", "Looks like, yes" };

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
}//eif
