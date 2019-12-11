using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class logicFactura
    {
        public double valor = 1000;
        public double cantidad = 10;
        public double iva = 0.19;
        public List<factura> listarFactura()
        {
            var factura1 = new factura()
            {
                id = 1,
                fechaFactura = new DateTime(2019, 12, 01),
                cantidad = 10,
                valor = 1000,
                subtotal = cantidad * valor,
                iva = 1900,
                total = ((valor * cantidad) * iva + (valor * cantidad))
            };

            var factura2 = new factura()
            {
                id = 2,
                fechaFactura = new DateTime(2019, 12, 01),
                cantidad = 20,
                valor = 10000,
                subtotal = 200000,
                iva = 38000,
                total = 238000

            };

            return new List<factura> { factura1, factura2 };
        }
    }
}