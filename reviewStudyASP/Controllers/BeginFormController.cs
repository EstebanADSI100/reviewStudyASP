using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Models;

namespace reviewStudyASP.Controllers
{
    public class BeginFormController : Controller
    {
        [HttpGet]
        public ActionResult mostrarPersona()
        {

            return View();
        }

        [HttpPost]
        public ActionResult mostrarPersona(Individuo individuo)
        {

            ViewBag.Message = "Proceso Exitoso";
            return View(individuo);
        }
    }
}