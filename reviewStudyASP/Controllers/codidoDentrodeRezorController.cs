using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class codidoDentrodeRezorController : Controller
    { 
        public ActionResult listarUsuarios()
        {
            var modelIni = new listarUsuario();
            var model = modelIni.readList();

            return View(model);
        }
    }
}