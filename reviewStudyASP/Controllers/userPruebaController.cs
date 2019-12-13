using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class userPruebaController : Controller
    {
        // GET: userPrueba
        public ActionResult mostrarUsuario()
        {
            var modeloInicial = new listarPruebaUsuario();
            var model = modeloInicial.readUserPrueba();

            return View(model);
        }
    }
}