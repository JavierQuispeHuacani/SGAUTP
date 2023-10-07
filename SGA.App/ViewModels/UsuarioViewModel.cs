using SGA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGA.App.ViewModels
{
    public class UsuarioViewModel
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

        public Usuario Usuario { get; set; }
        public IEnumerable<Usuario> Usuarios { get; set; }

        //public Expression<Func<Usuario, bool>> predicate { get; set; }
        //public int Id { get; set; }

    }
    public class UsuarioViewModels
    {
        public Usuario Usuario { get; set; }
    }


}
