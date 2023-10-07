using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SGA.Domain.Models;

namespace SGA.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario GetByIdUsuario(int id);
        IEnumerable<Usuario> ListUsuario();
        IEnumerable<Usuario> List(Expression<Func<Usuario, bool>> predicate);
        void Insert(Usuario entity);
        void Update(Usuario entity);
        void Delete(Usuario entity);
    }
}
