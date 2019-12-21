using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class IterarOrganismo
    {
        public  List<Organismo> listarOrg()
        {
            var organismo1 = new Organismo()
            {
                nombre = "Vista Parcial Juan",
                edad = 32
            };

            var organismo2 = new Organismo()
            {
                nombre = "Vista Parcial Pedro",
                edad = 69
            };

            var organismo3 = new Organismo()
            {
                nombre = "Vista Parcial Jose",
                edad = 45
            };

            return new List<Organismo> { organismo1, organismo2, organismo3 };
        }
    }
}