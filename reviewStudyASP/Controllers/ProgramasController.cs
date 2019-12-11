using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class ProgramasController : Controller
    {
        // GET: Programas
        public ActionResult listarProgramas()
        {
            var model = new logicPrograma();

            return View(model.listarProgramas());
        }
    }
}