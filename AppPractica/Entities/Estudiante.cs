using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppPractica.Entities
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        [DisplayName("Ingrese el nombre del estudiante")]
        public string Nombre { get; set; }
        [DisplayName("Ingrese la cedula del estudiante")]
        public string Cedula { get; set; }
        [DisplayName("Ingrese el nivel del estudiante")]
        public string Nivel { get; set; }
    }
}
