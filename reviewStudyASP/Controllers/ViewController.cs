using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult testViewProducto()
        {
            var producto = new logicProducto();
            var model = producto.ObtenerProductos();

            return View(model);
        }
    }
}