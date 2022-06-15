using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto_Vesa.Data;
using Proyecto_Vesa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

namespace Proyecto_Vesa.Controllers
{
    [Authorize]
    public class VentasController : Controller
    {
        private readonly ProjectDbContext _db;
        public VentasController(ProjectDbContext db)
        {
            _db = db;
        }
        // GET: VentasController
        public IActionResult Index(int? page = 1)
        {
            //Paginacion
            var pageNumber = page ?? 1;
            int pageSize = 10;

            //Listar Ventas
            ViewBag.Ventas = _db.Ventas.OrderBy(f=> f.Fecha).ToPagedList(pageNumber, pageSize);

            return View();
        }
    }
}
