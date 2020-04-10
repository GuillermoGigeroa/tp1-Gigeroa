using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Cliente
    {
        public int Id_cliente { get; set; }
        public int NivelDePrioridad { get; set; }
        public int NumeroDeCuenta { get; set; }
        public List<Compartimento> CompartimentosAlquilados = new List<Compartimento>();
    }
}
