using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //Generic Constraint
    //class : referans tip where T:class
    //IEntity : IEntity veya IEntity implemente eden bir nesne olabilir where T:IEntity
    public interface IEntityRepository<T> 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
