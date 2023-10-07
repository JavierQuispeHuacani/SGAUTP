using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SGA.Domain.Models;

namespace SGA.Domain.Interfaces
{
    public interface ICargoRepository
    {
        Cargo GetByIdCargo(int id);
        IEnumerable<Cargo> ListCargo();
        IEnumerable<Cargo> List(Expression<Func<Cargo, bool>> predicate);
        void Insert(Cargo entity);
        void Update(Cargo entity);
        void Delete(Cargo entity);
    }
}
