﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gigeroa
{
    class Sector
    {
        public int Id_sector { get; set; }
        public string Descripcion { get; set; }
        public List<Cargo> Cargos = new List<Cargo>();
        public List<Empleado> Empleados = new List<Empleado>();
    }
}
