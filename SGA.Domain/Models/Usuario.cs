using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Models
{
    public class Usuario
    {
        public int Cod_Usuario { get; set; }
        public string Nom_Usuario { get; set; }
        public string Pass_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Anexo { get; set; }
        public int Codigo_Area { get; set; }
        public int Codigo_Cargo { get; set; }
        public int Estado { get; set; }

    }
}
