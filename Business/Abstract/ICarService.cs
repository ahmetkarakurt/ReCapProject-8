using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarService
    {
        List<Car> GetAll();

        void add(Car car);
        
        
    }
}
