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
    public class AreaService : IAreaService
    {

        public IAreaRepository _areaRepository;

        public AreaService(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository;
        }


        public void Delete(AreaViewModels entity)
        {
            _areaRepository.Delete(entity.Area);
        }

        public AreaViewModel GetById(int id)
        {
            return new AreaViewModel { Area = _areaRepository.GetByIdArea(id) };
        }

        public void Insert(AreaViewModels entity)
        {
            _areaRepository.Insert(entity.Area);
        }

        public AreaViewModel List()
        {
            return new AreaViewModel { Areas = _areaRepository.ListArea() };
        }

        public IEnumerable<AreaViewModel> List(Expression<Func<AreaViewModel, bool>> predicate)
        {
            return null;
        }

        public void Update(AreaViewModels entity)
        {
            _areaRepository.Update(entity.Area);
        }
    }
}
