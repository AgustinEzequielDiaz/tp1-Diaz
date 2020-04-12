using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Diaz
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public string Comisiones { get; set; }
        public string PlanDeEstudio { get; set; }
        public string Modalidad { get; set; }
        public int CargaHoraria { get; set; }
        public string Correlativas { get; set; }
    }
}
