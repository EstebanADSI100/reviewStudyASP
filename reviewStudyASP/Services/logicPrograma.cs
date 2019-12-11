using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using reviewStudyASP.Models;

namespace reviewStudyASP.Services
{
    public class logicPrograma
    {
        public List<programas> listarProgramas()
        {
            var nombrePrograma1 = new programas()
            {
                idPrograma = 1,
                nombre = "Seudo-Codigo"
            };

            var nombrePrograma2 = new programas()
            {
                idPrograma = 2,
                nombre = "Java"
            };

            var nombrePrograma3 = new programas()
            {
                idPrograma = 3,
                nombre = "C#"
            };

            var nombrePrograma4 = new programas()
            {
                idPrograma = 4,
                nombre = "SQL-Server"
            };

            var nombrePrograma5 = new programas()
            {
                idPrograma = 5,
                nombre = "PHP"
            };

            var nombrePrograma6 = new programas()
            {
                idPrograma = 6,
                nombre = "My Sql"
            };

            var nombrePrograma7 = new programas()
            {
                idPrograma = 7,
                nombre = "JS"
            };

            var nombrePrograma8 = new programas()
            {
                idPrograma = 8,
                nombre = "Bootstrap"
            };

            return new List<programas> { nombrePrograma1, nombrePrograma2, nombrePrograma3, nombrePrograma4, nombrePrograma5, nombrePrograma6, nombrePrograma7, nombrePrograma8 };

        }
    }
}