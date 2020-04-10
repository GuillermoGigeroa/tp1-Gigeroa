using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Cargo
    {
        public int Id_cargo { get; set; }
        public string Descripcion { get; set; }
        public List<Empleado> Empleados = new List<Empleado>();
    }
}
