﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reviewStudyASP.Controllers
{
    public class RedirectToActionController : Controller
    {
        public RedirectToRouteResult redirecToAction()
        {
            return RedirectToAction("Contact", "Home");
        }
    }
}