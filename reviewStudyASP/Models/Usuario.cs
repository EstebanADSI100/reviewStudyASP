using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public class Usuario
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombreCompleto { get; set; }
        public int edad { get; set; }
        
        [Required]
        public bool estado { get; set; }
    }
}