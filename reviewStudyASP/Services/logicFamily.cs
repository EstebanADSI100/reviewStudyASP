using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class logicFamily
    {
        public family objectFamily()
        {
            return new family()
            {
                idFamily = 1,
                nameMother = "Fanny Díaz Gallego",
                nameBrotherHigher = "Juan Carlos Valiente Díaz",
                nameBrotherMedium = "John Alejandro Valiente Díaz"
            };
        }
    }
}