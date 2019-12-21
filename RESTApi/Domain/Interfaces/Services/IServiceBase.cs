using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        T GetById(int id);

        IEnumerable<T> GetAll();

        T Insert(T obj);

        T Update(T obj);

        void Remove(T obj);
    }
}
