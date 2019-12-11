using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reviewStudyASP.Controllers
{
    public class HttpGetAndHttpPostController : Controller
    {
        [HttpGet]
        public ActionResult testHttpGetAndPost()
        {
            ViewBag.Message = "Este es un ejemplo de la propiedad HttpGet";
            
            return View();
        }

        [HttpPost]
        public ActionResult testHttpGetAndPost(int edad)
        {
            ViewBag.Message = "Este es un ejemplo de la propiedad HttpPost" + "Edad:" + " " + edad;

            return View();
        }
    }
}