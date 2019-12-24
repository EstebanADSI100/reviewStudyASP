using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public class Pelicula
    {
        public int id { get; set; }
        
        [Required]
        [StringLength(130)]
        public string titulo { get; set; }
        public bool estaEnCartelera { get; set; }

        [StringLength(120)]
        public string genero { get; set; }

        [StringLength(1000)]
        public string sinopsis { get; set; } 
    }
}