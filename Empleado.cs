using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Empleado : Persona
    {
        public int Legajo { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public double Sueldo { get; set; }
    }
}
