﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepository<Order, NorthwindContext>, IOrderDal
    {
        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
