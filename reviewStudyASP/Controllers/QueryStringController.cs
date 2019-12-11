using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reviewStudyASP.Controllers
{
    public class QueryStringController : Controller
    {
        // GET: QueryString
        public ActionResult queryString(string nombre, int edad)
        {
            ViewBag.Message = "Nombre:" + " " + nombre + " " + "Edad:" + " " + edad;

            return View();
        }
    }
}