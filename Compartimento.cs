using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Compartimento
    {
        public int Id_compartimento { get; set; }
        public int CapacidadDeCajasTotal { get; set; }
        public int CapacidadDeCajasLibre { get; set; }
        public bool TieneDuenio { get; set; }
        public List<Caja> Cajas = new List<Caja>();
    }
}
