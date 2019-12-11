using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public class film
    {
        public int idFilm { get; set; }
        public DateTime dateStart { get; set; }
        public string nameFilm { get; set; }
        public string duration { get; set; }
        public bool stateInBillboard { get; set; }
    }
}