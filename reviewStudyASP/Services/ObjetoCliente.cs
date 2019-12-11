using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class ObjetoCliente
    {
        public Cliente obtenerCliente()
        {
            return new Cliente()
            {
                id = 1,
                nombre = "Jesús Esteban Valiente Díaz",
                estadoUsuario = false,
                fechaInicio = new DateTime(2019, 12, 03)
            };
        }
    }
}