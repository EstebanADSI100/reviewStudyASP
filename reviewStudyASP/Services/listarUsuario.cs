using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class listarUsuario
    {
        public List<users> readList()
        {
            var user1 = new users()
            {
                idUser = 1,
                dateBirth = new DateTime(1965, 04, 20),
                firstName = "Fanny",
                secondName = "",
                firstLast = "Díaz",
                secondLast = "Gallego",
                age = 54,
                phone = "3134314281",
                direction = "Calle 2 # 93D-30",
                state = true

            };

            var user2 = new users()
            {
                idUser = 2,
                dateBirth = new DateTime(1985, 07, 25),
                firstName = "Juan",
                secondName = "Carlos",
                firstLast = "Valiente",
                secondLast = "Díaz",
                age = 30,
                phone = "31287190182",
                direction = "Calle 2 # 93D-30",
                state = false

            };

            var user3 = new users()
            {
                idUser = 3,
                dateBirth = new DateTime(1989, 09, 25),
                firstName = "John",
                secondName = "Alejandro",
                firstLast = "Valiente",
                secondLast = "Díaz",
                age = 29,
                phone = "3115912534",
                direction = "Americas Crr 53d",
                state = false

            };

            var user4 = new users()
            {
                idUser = 4,
                dateBirth = new DateTime(1994, 04, 20),
                firstName = "Jesús",
                secondName = "Esteban",
                firstLast = "Valiente",
                secondLast = "Díaz",
                age = 25,
                phone = "3193067008",
                direction = "Pueblo Nuevo calle principal",
                state = true

            };

            var user5 = new users()
            {
                idUser = 5,
                dateBirth = new DateTime(1967, 01, 20),
                firstName = "Leonidas",
                secondName = "",
                firstLast = "Díaz",
                secondLast = "Gallego",
                age = 52,
                phone = "311234567",
                direction = "Calle principal pueblo nuevo",
                state = false

            };

            return new List<users> { user1, user2, user3, user4, user5 };
        }
    }
}