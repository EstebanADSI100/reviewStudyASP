using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class listarPruebaUsuario
    {
        public List<userPrueba> readUserPrueba()
        {
            var user1 = new userPrueba()
            {
                idUserPrueba = 1,
                name = "Javier Manzanares",
                state = false
            };

            var user2 = new userPrueba()
            {
                idUserPrueba = 2,
                name = "Petrolino Manzana mordida",
                state = false
            };

            var user3 = new userPrueba()
            {
                idUserPrueba = 3,
                name = "Juan Manuel Santos",
                state = true
            };

            return new List<userPrueba> { user1, user2, user3 };
        }
    }
}