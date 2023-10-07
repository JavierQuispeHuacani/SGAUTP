using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.MVC.Models
{
    public class ResponseArea
    {
        public string mensaje { get; set; }
        public List<AreaViewModel> lista { get; set; }
        public AreaViewModel objeto { get; set; }
    }
}
