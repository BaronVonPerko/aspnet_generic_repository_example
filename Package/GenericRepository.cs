using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class where TContext : DbContext
    {
        protected readonly TContext _db;

        protected GenericRepository(TContext db)
        {
            _db = db;
        }

        public IList<TEntity> GetAll()
        {
            return _db.Set<TEntity>().ToList();
        }

        public TEntity GetSingle(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity newObj)
        {
            _db.Set<TEntity>().Add(newObj);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _db.Set<TEntity>().Find(id);
            _db.Set<TEntity>().Remove(entity);
            _db.SaveChanges();
        }

        public virtual void Update(int id, TEntity updateObj)
        {
            throw new NotImplementedException();
        }
    }
}