using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.MVC.Models
{
    public class ResponseCargo
    {
        public string mensaje { get; set; }
        public List<CargoViewModel> lista { get; set; }
        public CargoViewModel objeto { get; set; }
    }
}
