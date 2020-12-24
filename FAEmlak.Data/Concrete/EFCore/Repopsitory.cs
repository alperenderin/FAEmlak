using System;
using FAEmlak.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace FAEmlak.Data.Concrete.EFCore
{
    public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        public void Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified; ;
            Context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }
        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }
    }
}
