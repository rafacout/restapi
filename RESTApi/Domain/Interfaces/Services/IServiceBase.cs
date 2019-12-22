using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        T FindById(long id);

        IEnumerable<T> FindAll();

        T Insert(T obj);

        T Update(T obj);

        bool Remove(long id);
    }
}
