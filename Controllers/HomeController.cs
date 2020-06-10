using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheRockBakery.Models;
using Microsoft.AspNetCore.Http;

namespace TheRockBakery.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Sniffs") == null)
            {
                HttpContext.Session.SetInt32("Sniffs",0);
            }
            int? sniff = HttpContext.Session.GetInt32("Sniffs");
            sniff ++;
            HttpContext.Session.SetInt32("Sniffs",(int)sniff);
            ViewBag.Sniffs = HttpContext.Session.GetInt32("Sniffs");
            BakeGood random = new BakeGood();
            
            return View(random);
        }


        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
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
