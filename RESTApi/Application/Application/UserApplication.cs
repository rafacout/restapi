using Application.Interfaces;
using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application
{
    public class UserApplication : IUserApplication
    {
        public Task<UserViewModel> AlterarAsync(long id, UserViewModel obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> InserirAsync(UserViewModel input)
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> SelecionarPorIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
