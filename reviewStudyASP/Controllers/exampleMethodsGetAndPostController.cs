using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;


namespace reviewStudyASP.Controllers
{
    public class exampleMethodsGetAndPostController : Controller
    {
        [HttpGet]       
        public ActionResult listarUser()
        {
            var model = new listarUser();
            
            return View(model.obtenerUser());
        }

        [HttpPost]

        
        public ActionResult listarUser(string email, string password)
        {
            ViewBag.Message = "Email:" + "  " + email + " | " + "Password:" + "  " + password;
            
            var model = new listarUser();
            
            return View(model.obtenerUser());
        }
    }
}