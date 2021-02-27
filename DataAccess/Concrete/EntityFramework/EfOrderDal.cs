using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfOrderDal :EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
    }
}
