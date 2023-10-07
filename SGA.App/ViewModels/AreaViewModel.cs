using SGA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.App.ViewModels
{
    public class AreaViewModel
    {
        public int Codigo_Area { get; set; }
        public string Nombre_Area { get; set; } 
        public int Estado { get; set; }
        public IEnumerable<Area> Areas { get; set; }
        public Area Area { get; set; }
    }

    public class AreaViewModels
    {
        public Area Area { get; set; }
    }
}
