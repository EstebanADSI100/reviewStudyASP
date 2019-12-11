using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool estadoUsuario { get; set; }
        public DateTime fechaInicio { get; set; }
    }
}