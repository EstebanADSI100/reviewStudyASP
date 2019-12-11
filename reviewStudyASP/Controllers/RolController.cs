using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult ListarRol()
        {
            var rol = new logicRol();
            var model = rol.listarRol();

            return View(model);
        }
    }
}