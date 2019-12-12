using System.Collections.Generic;

namespace Perko.Generic
{
    public interface IGenericRepository<TEntity>
    {
        IList<TEntity> GetAll();
        TEntity GetSingle(int id);
        void Insert(TEntity newObj);
        void Delete(int id);
        void Update(int id, TEntity updateObj);
    }
}