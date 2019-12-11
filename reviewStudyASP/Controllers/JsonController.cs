using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class JsonController : Controller
    {
        public JsonResult Json()
        {
            var user = new logicUsers();

            return Json(user.obtainUsers(), JsonRequestBehavior.AllowGet);
        }
    }
}