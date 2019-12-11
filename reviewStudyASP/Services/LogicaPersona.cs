using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;
using System.Globalization;

namespace reviewStudyASP.Services
{
    public class LogicaPersona
    {
        public Persona ListarPersona()
        {
            return new Persona()
            {
                Id = 1,
                Nombre = "Esteban",
                Empleado = true,
                FechaNacimiento = new DateTime(1994, 04, 20)
            };
        }
    }
}