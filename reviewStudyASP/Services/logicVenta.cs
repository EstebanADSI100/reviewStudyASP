using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class logicVenta
    {
        public venta listarVenta()
        {
            return new venta()
            {
                idVenta = 1,
                fechaVenta = new DateTime(2019, 11, 07),
                nit = "800.239.87-2",
                nombreEstablecimiento = "Claro",
                tipoUsuario = "Cliente",
                nombreCompleto = "Fedirico Longaniza",
                subtotal = 300000000,
                iva = 57000000,
                total = 357000000
            };
        }

        public List<venta> listarVentas()
        {
            var venta1 = new venta()
            {
                idVenta = 1,
                fechaVenta = new DateTime(2019, 11, 07),
                nit = "800.239.87-2",
                nombreEstablecimiento = "Claro",
                tipoUsuario = "Cliente",
                nombreCompleto = "Fedirico Longaniza",
                subtotal = 300000000,
                iva = 57000000,
                total = 357000000
            };

            var venta2 = new venta()
            {
                idVenta = 2,
                fechaVenta = new DateTime(2019, 11, 07),
                nit = "900.139.37-9",
                nombreEstablecimiento = "El Exito",
                tipoUsuario = "Cliente",
                nombreCompleto = "God",
                subtotal = 60000,
                iva = 11400,
                total = 71400
            };

            var venta3 = new venta()
            {
                idVenta = 3,
                fechaVenta = new DateTime(2019, 11, 07),
                nit = "1000.9.65-3",
                nombreEstablecimiento = "IBM",
                tipoUsuario = "Employee",
                nombreCompleto = "God Is bueno",
                subtotal = 90000,
                iva = 17100,
                total = 117100
            };

            return new List<venta> { venta1, venta2, venta3 };
        }

    }
}