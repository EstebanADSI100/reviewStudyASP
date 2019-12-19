using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace reviewStudyASP.Models
{
    public enum ResultadoOperacion
    {
        [Description("Activo")]
        activo = 1,

        [Description("Inactivo")]
        inactivo = 0,

        [Description("Bloqueado por fraude")]
        bloqueado = 2
    }
}