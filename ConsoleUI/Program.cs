using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFW;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.getAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
