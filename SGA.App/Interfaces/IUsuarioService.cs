using SGA.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGA.App.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioViewModel GetById(int id);
        UsuarioViewModel List();
        IEnumerable<UsuarioViewModel> List(Expression<Func<UsuarioViewModel, bool>> predicate);
        void Insert(UsuarioViewModels entity);
        void Update(UsuarioViewModels entity);
        void Delete(UsuarioViewModels entity);
    }
}
