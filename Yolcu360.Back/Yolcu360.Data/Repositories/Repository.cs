using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Repositories;

namespace Yolcu360.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly Yolcu360DbContext _context;

        public Repository(Yolcu360DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> exp, params string[] includes)
        {
            var query= _context.Set<TEntity>().AsQueryable();
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
            return query.FirstOrDefault(exp);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> exp, params string[] includes)
        {
            var query = _context.Set<TEntity>().AsQueryable();
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
            return query.Where(exp);
        }

        public bool IsExsist(Expression<Func<TEntity, bool>> exp)
        {
            return _context.Set<TEntity>().Any(exp);
        }
    }
}
