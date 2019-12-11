using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class listarUser
    {
        public loginUser obtenerUser()
        {
            return new loginUser()
            {
                email = "No pude Parce",
                password = "Después aprenderé"
            };
        }
    }
}