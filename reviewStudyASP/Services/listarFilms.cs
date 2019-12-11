using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class listarFilms
    {
        public List<film> readFilms()
        {
            var film1 = new film()
            {
                idFilm = 1,
                dateStart = new DateTime(2019, 11, 30, 19, 20, 001),
                nameFilm = "Terminator I",
                duration = "2 horas",
                stateInBillboard = true
            };

            var film2 = new film()
            {
                idFilm = 2,
                dateStart = new DateTime(2019, 10, 28, 23, 01, 002),
                nameFilm = "Terminator II",
                duration = "1 hora  y 50 Minutos",
                stateInBillboard = false
            };

            var film3 = new film()
            {
                idFilm = 3,
                dateStart = new DateTime(2019, 09, 30, 01, 35, 03),
                nameFilm = "El Depredador I",
                duration = "2 hora  y 50 Minutos",
                stateInBillboard = false
            };

            var film4 = new film()
            {
                idFilm = 4,
                dateStart = new DateTime(2019, 08, 20, 03, 10, 004),
                nameFilm = "Hombre Araña I",
                duration = "2 hora  y 30 Minutos",
                stateInBillboard = true
            };

            var film5 = new film()
            {
                idFilm = 5,
                dateStart = new DateTime(2019, 09, 28, 01, 35, 005),
                nameFilm = "La mascara",
                duration = "3 hora  y 10 Minutos",
                stateInBillboard = false
            };

            var film6 = new film()
            {
                idFilm = 6,
                dateStart = new DateTime(2017, 09, 10, 01, 35, 006),
                nameFilm = "Man Heroe",
                duration = "2 hora  y 15 Minutos",
                stateInBillboard = true
            };

            return new List<film> { film1, film2, film3, film4, film5, film6 };
        }
    }
}