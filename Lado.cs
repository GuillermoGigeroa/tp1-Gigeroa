using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Lado
    {
        public int Id_lado { get; set; }
        public string Nombre { get; set; }
        public List<Compartimento> Compartimentos = new List<Compartimento>();
    }
}
