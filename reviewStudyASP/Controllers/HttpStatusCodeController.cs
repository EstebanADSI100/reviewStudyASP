using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reviewStudyASP.Controllers
{
    public class HttpStatusCodeController : Controller
    {
        public HttpStatusCodeResult HttpStatusCode()
        {
            return new HttpStatusCodeResult(404, "Recurso No Encontrado");
        }
    }
}