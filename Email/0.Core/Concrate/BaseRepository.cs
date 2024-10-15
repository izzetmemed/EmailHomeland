using Email._0.Core.Abstract;
using Email.MyModel.Contexts;
using Email.MyModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Email._0.Core.Concrate
{
    public class BaseRepository<T, TContext> : IBaseRepository<T>
    where T : class, new()
    where TContext : DbContext, new()
    {
        public void Add(T Model)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(Model);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T Model)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(Model);
                addedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>>? predicate = null)
        {
            using (TContext context = new TContext())   
            {
                return predicate is null
                  ?
                   context.Set<T>().ToList()
                  :
                  context.Set<T>().Where(predicate).ToList();
            }
        }


        public T GetById(Expression<Func<T, bool>> predicate)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(predicate);
            }
        }

        public void Update(T Model)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(Model);
                addedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
