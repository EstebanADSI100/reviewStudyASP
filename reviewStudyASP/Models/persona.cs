using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Empleado { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        
    }
}