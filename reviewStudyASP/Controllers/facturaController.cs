using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class facturaController : Controller
    {
        // GET: factura
        public ActionResult reactFactura()
        {
            var modelFactura = new logicFactura();
            var model = modelFactura.listarFactura();
            return View(model);
        }
    }
}