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
    public class AreaRepository : IAreaRepository
    {
        public AppSettingsDbContext _context;

        public AreaRepository(AppSettingsDbContext context) {
            _context = context;
        }

        public IEnumerable<Area> ListArea()
        {
            return _context.Areas;
        }

        public void Delete(Area entity)
        {
            _context.Set<Area>().Remove(entity);
            _context.SaveChanges();
        }

        public Area GetByIdArea(int id)
        {
            return _context.Set<Area>().Find(id);
        }

        public void Insert(Area entity)
        {
            _context.Set<Area>().Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Area> List(Expression<Func<Area, bool>> predicate)
        {
            return  _context.Set<Area>().Where(predicate);
        }

        public void Update(Area entity)
        {
            _context.Entry<Area>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
