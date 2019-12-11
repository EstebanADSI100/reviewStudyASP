using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class logicProducto
    {
        public producto ObtenerProducto()
        {
            return new producto()
            {
                id = 1,
                firstName = "Jesús",
                firstLastName = "Valiente",
                dateOfBirth = new DateTime(1994, 04, 20)
            };
        }

        public List<producto> ObtenerProductos()
        {
            var product1 = new producto()
            {
                id = 1,
                firstName = "Ximena",
                firstLastName = "Cortes",
                dateOfBirth = new DateTime(1990, 04, 20)
            };

            var product2 = new producto()
            {
                id = 2,
                firstName = "Edith",
                firstLastName = "Gomez",
                dateOfBirth = new DateTime(1988, 04, 20)
            };

            var product3 = new producto()
            {
                id = 3,
                firstName = "Katerine",
                firstLastName = "Galicia",
                dateOfBirth = new DateTime(1994, 04, 20)
            };

            return new List<producto> {product1,product2,product3 };
        }
    }
}