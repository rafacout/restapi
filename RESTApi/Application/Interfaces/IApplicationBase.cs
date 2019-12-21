using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationBase<T>
    {
        Task<T> InserirAsync(T input);
        Task<T> AlterarAsync(long id, T obj);
        Task<bool> DeletarAsync(long id);
        Task<T> SelecionarPorIdAsync(long id);
    }
}
