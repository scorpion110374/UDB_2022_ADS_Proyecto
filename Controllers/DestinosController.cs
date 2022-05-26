using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Vesa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Proyecto_Vesa.Controllers
{
    public class DestinosController : Controller
    {
        private readonly ProjectDbContext _db;
        public DestinosController(ProjectDbContext db)
        {
            _db = db;
        }
        // GET: DestinosController
        public ActionResult Index(int? page = 1)
        {
            //Paginacion
            var pageNumber = page ?? 1;
            int pageSize = 4;

            //Listar Destinos
            ViewBag.Destinos = _db.Destinos.ToPagedList(pageNumber, pageSize);
            return View();
        }

        // GET: DestinosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DestinosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DestinosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DestinosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DestinosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DestinosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DestinosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
