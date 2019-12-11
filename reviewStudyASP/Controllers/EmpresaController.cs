using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult listarEmpresas()
        {
            var model = new logicEmpresa();

            return View(model.listarEmpresas());
        }
    }
}