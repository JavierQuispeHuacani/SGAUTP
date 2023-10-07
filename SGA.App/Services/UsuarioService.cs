using SGA.App.Interfaces;
using SGA.App.ViewModels;
using SGA.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGA.App.Services
{
    public class UsuarioService : IUsuarioService
    {

        public IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) {
            _usuarioRepository = usuarioRepository;
        }

        public void Delete(UsuarioViewModels entity)
        {
            _usuarioRepository.Delete(entity.Usuario);
        }

        public UsuarioViewModel GetById(int id)
        {
            return new UsuarioViewModel { Usuario = _usuarioRepository.GetByIdUsuario(id) };
        }

        public void Insert(UsuarioViewModels entity)
        {
           _usuarioRepository.Insert(entity.Usuario);
          
        }

        public UsuarioViewModel List()
        {
            return new UsuarioViewModel { Usuarios = _usuarioRepository.ListUsuario() };
        }

        public IEnumerable<UsuarioViewModel> List(Expression<Func<UsuarioViewModel, bool>>  predicate)
        {
            return null;
        }

        public void Update(UsuarioViewModels entity)
        {
            _usuarioRepository.Update(entity.Usuario);
        }
    }
}
