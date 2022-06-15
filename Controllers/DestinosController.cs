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
            int pageSize = 6;

            //Listar Destinos
            ViewBag.Destinos = _db.Destinos.ToPagedList(pageNumber, pageSize);
            return View();
        }

        // GET: DestinosController/Details/5
        public ActionResult Details(int id)
        {
            //Listar detalles de destinos
            ViewBag.Destino = _db.Destinos.Where(d=> d.Id == id).SingleOrDefault();
            //Array para galeria
            ViewBag.Galeria = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return View();
        }

        // GET: DestinosController/Promociones
        public ActionResult Promociones()
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

        //Carrito de Compras
        public ActionResult Carrito()
        {
            return View();
        }

        //Visualizar página de pago(checkout)
        public ActionResult Checkout()
        {
            //id de usuario registrado
            ViewBag.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View();
        }

        // POST: Página de pago(checkout)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Checkout(IFormCollection collection)
        {
            //Grabar venta
            Venta nuevaVenta = new Venta
            {
                Fecha = Convert.ToDateTime(collection["Fecha"]),
                IdUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier),
                Nombre = collection["Nombre"],
                Apellido = collection["Apellido"],
                Email = collection["Email"],
                Direccion = collection["Direccion"],
                Direccion2 = collection["Direccion2"],
                Telefono = collection["Telefono"],
                Pais = collection["Pais"],
                Departamento = collection["Departamento"],
                CodigoPostal = collection["CodigoPostal"],
                TipoPago = collection["paymentMethod"],
                Cc_name = collection["Cc_name"],
                Cc_number = collection["Cc_number"],
                Cc_expiration = collection["Cc_expiration"],
                Cc_cvv = collection["Cc_cvv"],
                Valor = Convert.ToDecimal(collection["Valor"])
            };

            _db.Ventas.Add(nuevaVenta);
            _db.SaveChanges();

            //Llamar ultima orden grabada
            int UltimaIdVenta = _db.Ventas.Max(item => item.Id);

            //Grabar detalle de venta
            //Revisar venga detalle
            string ListProducts = collection["listadoProductos"];

            if (ListProducts != null)
            {
                dynamic ListaProductos = JsonConvert.DeserializeObject(ListProducts);

                foreach (var detalle in ListaProductos)
                {
                    VentaDetalle ventaDetalle = new VentaDetalle();

                    ventaDetalle.IdVenta = UltimaIdVenta;
                    ventaDetalle.IdDestino = Convert.ToInt32(detalle["id"]);
                    ventaDetalle.FechaPaquete = Convert.ToDateTime(detalle["fecha"]);
                    ventaDetalle.Cantidad = Convert.ToInt32(detalle["cantidad"]);
                    ventaDetalle.PrecioUnitario = Convert.ToDecimal(detalle["precio"]);
                    ventaDetalle.SubTotal = Convert.ToDecimal(detalle["subTotal"]);

                    _db.VentaDetalles.Add(ventaDetalle);
                }
            }

            _db.SaveChanges();
            TempData["Carrito"] = "Borrar Carrito";
            TempData["Mensaje"] = "Venta procesada correctamente!";
            return RedirectToAction("Index", "Destinos");
        }
    }
}
