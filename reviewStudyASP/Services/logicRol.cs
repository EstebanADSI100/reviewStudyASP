using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class logicRol
    {
        public List<rol>  listarRol()
        {
            var rol1 = new rol()
            {
                idRol = 1,
                nameRol = "Cliente"
            };

            var rol2 = new rol()
            {
                idRol = 2,
                nameRol = "Empleado"
            };

            return new List<rol> { rol1, rol2 }; 
        }
    }
}