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
    public class CargoRepository : ICargoRepository
    {
        public AppSettingsDbContext _context;

        public CargoRepository(AppSettingsDbContext context)
        {
            _context = context;
        }

        public void Delete(Cargo entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Cargo GetByIdCargo(int id)
        {
            return _context.Set<Cargo>().Find(id);
        }

        public void Insert(Cargo entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Cargo> List(Expression<Func<Cargo, bool>> predicate)
        {
            return _context.Set<Cargo>().Where(predicate);
        }

        public IEnumerable<Cargo> ListCargo()
        {
            return _context.Cargos;
        }

        public void Update(Cargo entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
