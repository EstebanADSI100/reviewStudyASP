using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reviewStudyASP.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: ViewData
        public ActionResult testViewData()
        {
            ViewData["Name"] = "Esteban";
            ViewData["Age"] = 25;
            ViewData["fechaNacimiento"] = new DateTime(1994, 04, 20);

            return View();
        }
    }
}