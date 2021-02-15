using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstroct
{
    public interface IProductDal : IEntityRepository<Product>
    {


    }
}
