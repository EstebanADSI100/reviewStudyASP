using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public class factura
    {
        public int id { get; set; }
        public DateTime fechaFactura { get; set; }
        public double cantidad { get; set; }
        public double valor { get; set; }
        public double subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
    }
}