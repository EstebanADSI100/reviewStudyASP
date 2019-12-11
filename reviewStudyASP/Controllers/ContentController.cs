using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reviewStudyASP.Controllers
{
    public class ContentController : Controller
    {
        public ContentResult testContent()
        {
            return Content("<strong>Esto es un string de un action ContentResult</strong>");
            //return View();
        }
    }
}