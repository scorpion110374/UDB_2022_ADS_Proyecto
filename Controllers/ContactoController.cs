using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto_Vesa.Data;
using Proyecto_Vesa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Vesa.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ProjectDbContext _db;
        public ContactoController(ProjectDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            List<SelectListItem> listarTemas = new List<SelectListItem>();
            listarTemas.Add(new SelectListItem { Text = "Consulta", Value = "Consulta" });
            listarTemas.Add(new SelectListItem { Text = "Felicitación", Value = "Felicitación" });
            listarTemas.Add(new SelectListItem { Text = "Problema", Value = "Problema" });
            listarTemas.Add(new SelectListItem { Text = "Queja", Value = "Queja" });

            ViewBag.listaTemas = listarTemas;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(Contacto Contacto)
        {
            if (ModelState.IsValid)
            {
                _db.Contactos.Add(Contacto);
                await _db.SaveChangesAsync();

                TempData["Mensaje"] = "Mensaje enviado!";

                return RedirectToAction("Index", "Home");

            }
            return View();
        }
    }
}
