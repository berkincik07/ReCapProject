using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {

            new Car {Id = 1,BrandId = 1,ColorId=1,DailyPrice= 500, Description="BMW",ModelYear= "2015"},
            new Car {Id = 2,BrandId = 1,ColorId=3,DailyPrice= 600, Description="Audi",ModelYear= "2012"},
            new Car {Id = 3,BrandId = 2,ColorId=3,DailyPrice= 800, Description="Mercedes",ModelYear= "2013"},
            new Car {Id = 4,BrandId = 2,ColorId=2,DailyPrice= 5000, Description="Volkswagen",ModelYear= "2018"},
            new Car {Id = 5,BrandId = 3,ColorId=2,DailyPrice= 200, Description="Peugeot",ModelYear= "2020"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => car.Id == c.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public List<Car> GetCars(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
