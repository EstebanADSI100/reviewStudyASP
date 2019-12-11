using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public class users
    {
        public int idUser { get; set; } 
        public DateTime dateBirth { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string firstLast { get; set; }
        public string secondLast { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
        public string direction { get; set; }
        public bool state { get; set; }
    }
}