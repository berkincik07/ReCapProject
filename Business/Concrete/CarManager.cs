using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> AddCar()
        {
            return _carDal.GetCars(c => c.DailyPrice > 0 && c.Description.Length > 2);
        }

        public List<Car> getAll()
        {
            return _carDal.GetCars();
        }

        
    }
}
