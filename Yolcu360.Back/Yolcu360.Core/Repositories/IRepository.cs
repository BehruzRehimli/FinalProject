using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Repositories
{
    public interface IRepository<TEntity>
    {
        void Delete(TEntity entity);
        int Commit();
        void Add(TEntity entity);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity,bool>> exp,params string[] includes);
        TEntity Get(Expression<Func<TEntity, bool>> exp,params string[] includes);
        bool IsExsist(Expression<Func<TEntity, bool>> exp);
    }
}
