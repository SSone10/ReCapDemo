using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
  public  class InMemoryCarDal : ICarDal
        
    {
        List<Car> _Cars;
        public InMemoryCarDal()
        {
            _Cars = new List<Car>
            {
                new Car{Id = 1,BrandId=1,ColorId=1,DailyPrice="5",ModelYear="2019",Description="2019 MODEL SPORT"},
                new Car{Id = 2,BrandId=2,ColorId=2,DailyPrice="7",ModelYear="2017",Description="2017 MODEL SPORT"},
                new Car{Id = 3,BrandId=3,ColorId=3,DailyPrice="4",ModelYear="2018",Description="2018 MODEL SPORT"},
                new Car{Id = 4,BrandId=4,ColorId=4,DailyPrice="9",ModelYear="2015",Description="2015 MODEL SPORT"},
                new Car{Id = 5,BrandId=5,ColorId=5,DailyPrice="6",ModelYear="2013",Description="2013 MODEL SPORT"}
            };
        }
        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarDelete = _Cars.SingleOrDefault(c => c.Id == car.Id);
            _Cars.Remove(CarDelete);
        }

        public List<Car> GetAll()
        {
            return _Cars;
        }

        public List<Car> GetByID(int ıd)
        {
            return _Cars.Where(c => c.Id == ıd).ToList();
        }

        public void Update(Car car)
        {
            Car CarUpdate = _Cars.SingleOrDefault(c => c.Id == car.Id);
            CarUpdate.Id = car.Id;
            CarUpdate.BrandId = car.BrandId;
            CarUpdate.ColorId = car.ColorId;
            CarUpdate.ModelYear = car.ModelYear;
            car.DailyPrice = car.DailyPrice;
            car.Description = car.Description;
        }
    }
}
