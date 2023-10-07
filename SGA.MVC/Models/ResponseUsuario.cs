using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.MVC.Models
{
    public class ResponseUsuario
    {
        public string mensaje { get; set; }
        public List<UsuarioViewModel> lista { get; set; }
        public UsuarioViewModel objeto { get; set; }
    }
}
