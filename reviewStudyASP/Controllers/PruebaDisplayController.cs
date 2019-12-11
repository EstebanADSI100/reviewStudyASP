using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class PruebaDisplayController : Controller
    {
        // GET: PruebaDisplay
        public ActionResult verCliente()
        {
            var modelCliente = new ObjetoCliente();
            var model = modelCliente.obtenerCliente();

            ViewBag.cliente = model;
            return View();
        }
    }
}