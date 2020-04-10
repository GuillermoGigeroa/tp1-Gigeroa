using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Pasillo
    {
        public int Id_pasillo { get; set; }
        public string Nombre { get; set; }
        public List<Lado> lados = new List<Lado>();
    }
}
