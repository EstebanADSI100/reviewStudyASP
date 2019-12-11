using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class FamilyController : Controller
    {
        // GET: Family
        public ActionResult objectFamily()
        {
            var model = new logicFamily();

            return View(model.objectFamily());
        }
    }
}