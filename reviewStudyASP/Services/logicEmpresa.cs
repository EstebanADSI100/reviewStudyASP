using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class logicEmpresa
    {
        public List<empresa> listarEmpresas()
        {
            var empresa1 = new empresa()
            {
                idEmpresa = 1,
                nameEmpresa = "Punto de servicios S.A"
            };

            var empresa2 = new empresa()
            {
                idEmpresa = 2,
                nameEmpresa = "Atento Colombia"
            };

            var empresa3 = new empresa()
            {
                idEmpresa = 3,
                nameEmpresa = "Keep it simple"
            };

            var empresa4 = new empresa()
            {
                idEmpresa = 4,
                nameEmpresa = "Corferias"
            };

            var empresa5 = new empresa()
            {
                idEmpresa = 5,
                nameEmpresa = "Grupo Mok"
            };

            return new List<empresa> { empresa1, empresa2, empresa3, empresa4, empresa5 };
        }
    }
}