using Application.Interfaces;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Application
{
    public class ApplicationBase<T> : IApplicationBase<T> where T : class
    {
        private readonly IServiceBase<T> _serviceBase;

        public ApplicationBase(IServiceBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public bool DeleteAsync(long id)
        {
            return _serviceBase.Remove(id);
        }

        public IEnumerable<T> FindAll()
        {
            return _serviceBase.FindAll();
        }

        public T FindByIdAsync(long id)
        {
            return _serviceBase.FindById(id);
        }

        public T InsertAsync(T obj)
        {
            return _serviceBase.Insert(obj);
        }

        public T UpdateAsync(T obj)
        {
            return _serviceBase.Update(obj);
        }
    }
}
