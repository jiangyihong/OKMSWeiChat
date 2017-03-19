using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OKMS.WeiChat.IReopsitory
{
    public interface IBaseRepository<T> where T : class ,new()
    {
        bool Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        T Get(Expression<Func<T, bool>> wherExpression);

        IEnumerable<T> GetList<TKey>(int skip, int take, Expression<Func<T, TKey>> orderExpression, bool isDesc,
            out int count);

        IEnumerable<T> GetList<TKey>(Expression<Func<T, bool>> wherExpression, Expression<Func<T, TKey>> orderExpression,
        bool isDesc, int skip, int take, out int count);
    }
}
