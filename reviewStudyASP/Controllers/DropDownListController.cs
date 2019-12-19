using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewStudyASP.Services;

namespace reviewStudyASP.Controllers
{
    public class DropDownListController : Controller
    {
        // GET: DropDownList
        public ActionResult drop()
        {
            ViewBag.estado = listarEstado();
            return View();
        }
        public List<SelectListItem> listarEstado()
        {
            return new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Text = "Activo",
                        Value = "1"
                    },

                    new SelectListItem()
                    {
                        Text = "Inactivo",
                        Value = "0"
                    }
                };
        }
    }
}