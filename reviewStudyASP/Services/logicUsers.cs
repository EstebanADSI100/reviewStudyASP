﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class logicUsers
    {
        public users obtainUser()
        {
            return new users()
            {
                idUser = 1,
                firstName = "Javier",
                secondName = "",
                firstLast = "Mendez",
                secondLast = "Garzón",
                age = 54,
                phone = "3134314281",
                direction = "Calle 2 # 93D-30"
            };
        }

        public List<users> obtainUsers()
        {
            var user1 = new users()
            {
                idUser = 1,
                firstName = "Luis",
                secondName = "",
                firstLast = "Díaz",
                secondLast = "Marquéz",
                age = 54,
                phone = "1212121234",
                direction = "Ciudad Bonita"
            };

            var user2 = new users()
            {
                idUser = 2,
                firstName = "Juan",
                secondName = "Carlos",
                firstLast = "Marquez",
                secondLast = "Díaz",
                age = 30,
                phone = "1112121212",
                direction = "Cidudad perdida"
            };

            var user3 = new users()
            {
                idUser = 3,
                firstName = "John",
                secondName = "Mariano",
                firstLast = "Mendez",
                secondLast = "Castro",
                age = 28,
                phone = "111111121",
                direction = "Postobon"
            };

            var user4 = new users()
            {
                idUser = 4,
                firstName = "Leonidas",
                secondName = "",
                firstLast = "Díaz",
                secondLast = "Rivera",
                age = 85,
                phone = "3125099362",
                direction = "Calle Principal Pueblo Nuevo - Nilo -Cundi"
            };

            var user5 = new users()
            {
                idUser = 5,
                firstName = "Jose",
                secondName = "",
                firstLast = "León",
                secondLast = "",
                age = 84,
                phone = "3125099362",
                direction = "Calle Principal Pueblo Nuevo - Nilo -Cundi"
            };

            var user6 = new users()
            {
                idUser = 6,
                firstName = "Luis",
                secondName = "Carlos",
                firstLast = "Díaz",
                secondLast = "Gallego",
                age = 60,
                phone = "3128789872",
                direction = "Cucutá"
            };

            var user7 = new users()
            {
                idUser = 7,
                firstName = "Libardo",
                secondName = "",
                firstLast = "Díaz",
                secondLast = "Gallego",
                age = 62,
                phone = "3121234567",
                direction = "Calle Principal Pueblo Nuevo - Nilo -Cundi"
            };

            var user8 = new users()
            {
                idUser = 8,
                firstName = "Yulitza",
                secondName = "",
                firstLast = "Díaz",
                secondLast = "Gallego",
                age = 63,
                phone = "3128789872",
                direction = "AV Americas KR 53 "
            };

            var user9 = new users()
            {
                idUser = 9,
                firstName = "Juan",
                secondName = "",
                firstLast = "Torres",
                secondLast = "",
                age = 24,
                phone = "3128789872",
                direction = "Tabora"
            };

            var user10 = new users()
            {
                idUser = 10,
                firstName = "Yuri",
                secondName = "Ximena",
                firstLast = "Cortes",
                secondLast = "Ramirez",
                age = 27,
                phone = "3022863206",
                direction = "Calera"
            };

            var user11 = new users()
            {
                idUser = 11,
                firstName = "Yeraldine",
                secondName = "",
                firstLast = "",
                secondLast = "Pulido",
                age = 30,
                phone = "3128789872",
                direction = "España"
            };

            return new List<users> { user1, user2, user3, user4, user5, user6, user7, user8, user9, user10, user11 };
        }
    }
}