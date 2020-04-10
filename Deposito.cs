using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Deposito
    {
        public int Id_deposito { get; set; }
        public string Nombre { get; set; }
        public int CapacidadDeCajas { get; set; }

        public List<Pasillo> Pasillos = new List<Pasillo>();
        public Domicilio Ubicacion { get; set; }

    }
}
