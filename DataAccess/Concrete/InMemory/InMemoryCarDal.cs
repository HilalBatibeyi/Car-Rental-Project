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
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 4, DailyPrice = 1550000, Description = "Audi A6", ModelYear = 2016},
                new Car{CarId = 2, BrandId = 2, ColorId = 5, DailyPrice = 2750000, Description = "BMW M3 ", ModelYear = 2021},
                new Car{CarId = 3, BrandId = 3, ColorId = 2, DailyPrice = 3620000, Description = "Volvo XC90", ModelYear = 2021},
                new Car{CarId = 4, BrandId = 4, ColorId = 3, DailyPrice = 5550000, Description = "Lexus 500H", ModelYear = 2020},
                new Car{CarId = 5, BrandId = 4, ColorId = 1, DailyPrice = 1995000, Description = "Lexus 300H", ModelYear = 2020},
                new Car{CarId = 6, BrandId = 5, ColorId = 1, DailyPrice = 1375000, Description = "Mercedes CLA200", ModelYear = 2020},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
