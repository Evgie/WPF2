using System;
using System.Collections.Generic;
using System.Text;

namespace ToyStore.DAL.Services
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Delete(int id);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Add(TEntity entity);
        void Save();
    }
}