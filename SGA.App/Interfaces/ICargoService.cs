using SGA.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGA.App.Interfaces
{
    public interface ICargoService
    {
        CargoViewModel GetById(int id);
        CargoViewModel List();
        IEnumerable<CargoViewModel> List(Expression<Func<CargoViewModel, bool>> predicate);
        void Insert(CargoViewModels entity);
        void Update(CargoViewModels entity);
        void Delete(CargoViewModels entity);
    }
}
