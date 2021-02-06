using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint
    //class: reference type
    //IEntity: May be IEntity or an object that implements IEntity
    //new(): Must be able to be instantiated (IEntity itself cannot be instantiated)
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {        
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T product);
    }
}
