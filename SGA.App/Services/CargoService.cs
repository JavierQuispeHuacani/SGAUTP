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
    public class CargoService : ICargoService
    {

        public ICargoRepository _cargoRepository;

        public CargoService(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public void Delete(CargoViewModels entity)
        {
            _cargoRepository.Delete(entity.Cargo);
        }

        public CargoViewModel GetById(int id)
        {
            return new CargoViewModel { Cargo = _cargoRepository.GetByIdCargo(id) };
        }

        public void Insert(CargoViewModels entity)
        {
            _cargoRepository.Insert(entity.Cargo);
        }

        public CargoViewModel List()
        {
            return new CargoViewModel { Cargos = _cargoRepository.ListCargo() };
        }

        public IEnumerable<CargoViewModel> List(Expression<Func<CargoViewModel, bool>> predicate)
        {
            return null;
        }

        public void Update(CargoViewModels entity)
        {
            _cargoRepository.Update(entity.Cargo);
        }
    }
}
