using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Diaz
{
    public class Alumno: Persona
    {
        public string Cuenta { get; set; }
        public string Carrera { get; set; }
        public string EstadoAcademico { get; set; }
        public string Inscripcion { get; set; }
        public string Correlativas { get; set; }
    }
}
