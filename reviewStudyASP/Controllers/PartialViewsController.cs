using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class PartialViewsController : Controller
    {
        // GET: PartialViews
        public ActionResult mostrarOrganismo()
        {
            var modelOrganismo = new IterarOrganismo();
            var model = modelOrganismo.listarOrg();

            return View(model);
        }
    }
}