using Business.Abstract;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;

        }

        public void add(Car car)
        {
            if (car.Description.Length>=2 && car.DailyPrice>0 )         
                _CarDal.Add(car);
            
          
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }
    }
}
