using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SGA.Domain.Models;

namespace SGA.Domain.Interfaces
{
    public interface IAreaRepository 
    {
        Area GetByIdArea(int id);
        IEnumerable<Area> ListArea();
        IEnumerable<Area> List(Expression<Func<Area, bool>> predicate);
        void Insert(Area entity);
        void Update(Area entity);
        void Delete(Area entity);


    }
}
