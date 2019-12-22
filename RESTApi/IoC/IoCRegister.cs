using Application.Application;
using Application.Interfaces;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    public static class IoCRegister
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterApplication(services);
            RegisterService(services);
            RegisterRepository(services);
        }
  
        private static void RegisterApplication(IServiceCollection services)
        {
            services.AddScoped<IUserApplication, UserApplication>();
        }

        private static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
        
        private static void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }

    }


}
