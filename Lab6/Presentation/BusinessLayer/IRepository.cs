using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Save();
    }
}
