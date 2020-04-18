using System;
using Microsoft.AspNetCore.Mvc;
using Rental.Models;
using System.Collections.Generic;

namespace Rental.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index(){
            return View(); 
        }

        public IActionResult Register(){
            return View(); 
        }

        [HttpGet]
        
        public IActionResult GetCatalog(){
            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.Year = 2019;
            c1.Description = "This is a fuel efficent car that you cant rent on a cheap...";
            c1.DailyPrice = 12.99m;
            c1.ImageUrl = "https://fotos02.autofacil.es/2019/09/12/690x278/fordfocusactive.jpeg";
            
            Car c2 = new Car();
            c2.Make = "Mazda";
            c2.Model = "6";
            c2.Year = 2011;
            c2.DailyPrice = 21.34m;
            c2.Description = "This is a fuel efficent car that you cant rent on a cheap...";
            c2.ImageUrl = "https://http2.mlstatic.com/antifaz-mazda-6-2011-2012-bordado-mazda-D_NQ_NP_771056-MLM31916865916_082019-F.jpg";

            List<Car> list = new List<Car>();
            list.Add(c1);
            list.Add(c2);

            return Json(list);
        }
    }
}