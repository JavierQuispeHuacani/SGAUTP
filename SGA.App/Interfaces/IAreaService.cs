using SGA.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGA.App.Interfaces
{
    public interface IAreaService
    {
        AreaViewModel GetById(int id);
        AreaViewModel List();
        IEnumerable<AreaViewModel> List(Expression<Func<AreaViewModel, bool>> predicate);
        void Insert(AreaViewModels entity);
        void Update(AreaViewModels entity);
        void Delete(AreaViewModels entity);
    }
}
