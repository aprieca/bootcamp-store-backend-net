﻿

namespace bootcamp_store_backend.Domain.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(long id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(long id);

    }
}