using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class filmController : Controller
    {
        public ActionResult readFilms()
        {
            var model = new listarFilms();
            return View(model.readFilms());
        }
    }
}