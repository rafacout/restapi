using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);

        T FindById(long id);

        IEnumerable<T> FindAll();

        void Update(T obj);

        void Remove(long id);
    }
}
