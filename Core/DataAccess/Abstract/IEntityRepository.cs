using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);

        TEntity Get(Expression<Func<TEntity,bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
