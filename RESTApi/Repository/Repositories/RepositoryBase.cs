using Data.Context;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApiContext _context;

        public RepositoryBase(ApiContext context)
        {
            _context = context;
        }

        public virtual void Add(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> FindAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T FindById(long id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual void Remove(long id)
        {
            //_context.Set<T>().Remove(id);
            _context.SaveChanges();
        }

        public virtual void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
