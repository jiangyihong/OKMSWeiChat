using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OKMS.WeiChat.Repository
{
    public class BaseRepository<T> where T : class,new()
    {
        protected readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            _dbContext.Set<T>().AddOrUpdate(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public T Get(Expression<Func<T, bool>> wherExpression)
        {
            return _dbContext.Set<T>().Find(wherExpression);
        }

        public IEnumerable<T> GetList<TKey>(int skip, int take, Expression<Func<T, TKey>> orderExpression, bool isDesc, out int count)
        {
            count = _dbContext.Set<T>().Count();
            if (isDesc)
            {
                return _dbContext.Set<T>()
                    .OrderByDescending(orderExpression)
                    .Skip(skip)
                    .Take(take).ToList();
            }

            return _dbContext.Set<T>().OrderBy(orderExpression).Skip(skip).Take(take).ToList();
        }

        public IEnumerable<T> GetList<TKey>(Expression<Func<T, bool>> wherExpression, Expression<Func<T, TKey>> orderExpression, bool isDesc, int skip, int take,
            out int count)
        {
            count = _dbContext.Set<T>().Count(wherExpression);
            if (isDesc)
            {
                return _dbContext.Set<T>()
                    .Where(wherExpression)
                    .OrderByDescending(orderExpression)
                    .Skip(skip)
                    .Take(take).ToList();
            }

            return _dbContext.Set<T>().Where(wherExpression).OrderBy(orderExpression).Skip(skip).Take(take).ToList();
        }

        public void Dispose()
        {
            if (_dbContext != null) _dbContext.Dispose();
        }

    }
}
