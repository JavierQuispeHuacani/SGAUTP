using SGA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.App.ViewModels
{
    public class CargoViewModel
    {

        public int Codigo_Cargo { get; set; }
        public string Nombre_Cargo { get; set; }
        public int Estado { get; set; }

        public IEnumerable<Cargo> Cargos { get; set; }
        public Cargo Cargo { get; set; }
    }
    public class CargoViewModels
    {
        public Cargo Cargo { get; set; }
    }
}
