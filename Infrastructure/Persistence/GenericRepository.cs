﻿
using bootcamp_store_backend.Domain.Persistence;
using Microsoft.EntityFrameworkCore;


namespace bootcamp_store_backend.Infrastructure.Persistence;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly DbContext _context;
    protected readonly DbSet<T> _dbSet;

    public GenericRepository(StoreContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public virtual List<T> GetAll()
    {
        return _dbSet.ToList<T>();
    }

    public virtual T GetById(long id)
    {
        var entity = _dbSet.Find(id);
        if (entity == null)
        {
            throw new ElementNotFoundException();
        }

        return entity;
    }

    public virtual T Insert(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public virtual T Update(T entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
        return entity;
    }

    public virtual void Delete(long id)
    {
        var entity = _dbSet.Find(id);
        if (entity == null) {
            throw new ElementNotFoundException();
        }
        _dbSet.Remove(entity);
        _context.SaveChanges();
    }
}

