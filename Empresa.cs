using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Empresa
    {
        public string Nombre { get; set; }
        public int Id_empresa { get; set; }
        public List<Sector> Sectores = new List<Sector>();
        public List<Contacto> Contactos = new List<Contacto>();
    }
}
