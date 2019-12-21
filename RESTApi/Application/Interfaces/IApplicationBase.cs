using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationBase<T>
    {
        T InsertAsync(T input);
        T UpdateAsync(long id, T obj);
        bool DeleteAsync(long id);
        T FindByIdAsync(long id);
    }
}
