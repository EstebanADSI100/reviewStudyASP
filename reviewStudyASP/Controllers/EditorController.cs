﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class EditorController : Controller
    {
        // GET: Editor
        public ActionResult mostrarObjetoPersona()
        {
            var modelEditor = new methodsEditorPersona();
            var model = modelEditor.listarPersona();
            ViewBag.editor = model;

            return View();
        }
    }
}