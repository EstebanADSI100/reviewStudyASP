using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public class venta
    {
        public int idVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public string nit { get; set; }
        public string nombreEstablecimiento { get; set; }
        public string tipoUsuario { get; set; }
        public string nombreCompleto { get; set; }
        public double subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
    }
}