using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserService _userService;

        public UserApplication(IUserService userService)
        {
            _userService = userService;
        }

        public bool DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserViewModel> FindAll()
        {
            throw new NotImplementedException();
        }

        public UserViewModel FindByIdAsync(long id)
        {
            var user = new UserViewModel();

            var result = _userService.FindById(id);

            if (result != null)
            { 
                user.Id = result.Id;
                user.FirstName = result.FirstName;
                user.LastName = result.LastName;
                user.UserName = result.UserName;
            }

            return user;
        }

        public UserViewModel InsertAsync(UserViewModel input)
        {
            throw new NotImplementedException();
        }

        public UserViewModel UpdateAsync(UserViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
