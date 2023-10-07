using SGA.Domain.Interfaces;
using SGA.Domain.Models;
using SGA.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SGA.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public AppSettingsDbContext _context;

        public UsuarioRepository(AppSettingsDbContext context)
        {
            _context = context;
        }


        public void Delete(Usuario entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Usuario GetByIdUsuario(int id)
        {
            return _context.Set<Usuario>().Find(id);
        }

        public void Insert(Usuario entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Usuario> List(Expression<Func<Usuario, bool>> predicate)
        {
            return _context.Set<Usuario>().Where(predicate);
        }

        public IEnumerable<Usuario> ListUsuario()
        {
            return _context.Usuarios;
        }

        public void Update(Usuario entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
