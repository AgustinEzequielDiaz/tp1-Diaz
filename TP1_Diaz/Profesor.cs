using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Diaz
{
    public class Profesor : Persona
    {
        public string Cuenta { get; set; }
        public string Materia { get; set; }
        public string Cargo { get; set; }
        public int Horario { get; set; }
        public string Avisos { get; set; }
    }
}
