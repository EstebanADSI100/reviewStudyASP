using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class DisplayController : Controller
    {
        // GET: display
        public ActionResult ReadPerson()
        {
            var modelPerson = new LogicaPersona();
            var model = modelPerson.ListarPersona();
            ViewBag.persona = model;
            return View();
        }
    }
}