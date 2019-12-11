using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reviewStudyASP.Controllers
{
    public class ViewBagController : Controller
    {
        public ActionResult testViewBag()
        {
            ViewBag.Name = "Jesús Esteban Valiente Díaz";
            ViewBag.Age = 25;
            ViewBag.FechaNacimiento = new DateTime (1994, 04, 20);

            return View();
        }
    }
}