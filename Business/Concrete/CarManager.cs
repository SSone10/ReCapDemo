using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _IcarDal;

        public CarManager(ICarDal ıcarDal)
        {
            _IcarDal = ıcarDal;
        }
        public List<Car> GetAll()
        {
            return _IcarDal.GetAll();
        }
    }
}
