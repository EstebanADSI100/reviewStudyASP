using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class VentaController : Controller
    {
        // GET: Venta
        public ActionResult listarVenta()
        {
            var classLogicVenta = new logicVenta();
         
            var model = classLogicVenta.listarVentas();

            return View(model);
        }

        public ActionResult listarUnaVenta()
        {
            var logica = new logicVenta();
            var model1 = logica.listarVenta();

            return View(model1);
        }
    }
}