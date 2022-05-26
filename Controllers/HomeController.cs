using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Vesa.Data;
using Proyecto_Vesa.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Vesa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectDbContext _db;
        public HomeController( ProjectDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Banner = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return View();
        }


        public IActionResult Nosotros()
        {
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
