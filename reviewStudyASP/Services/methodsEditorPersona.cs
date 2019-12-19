using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class methodsEditorPersona
    {
        public Persona listarPersona()
        {
            return new Persona()
            {
                Id = 1,
                Nombre = "Perro Loco",
                Empleado = true,
                FechaNacimiento = new DateTime(1991, 01, 02)
            };
        }
    }
}