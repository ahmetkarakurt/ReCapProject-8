using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductServices
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryID(int id);
    }
}
