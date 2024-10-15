using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Email._0.Core.Abstract
{
    public interface IBaseRepository<T> where T: class
    {
        void Add(T Model);
        void Delete(T Model);
        void Update(T Model);
        T GetById(Expression<Func<T, bool>> predicate);
        List<T> GetAll(Expression<Func<T, bool>> predicate);
    }
}
