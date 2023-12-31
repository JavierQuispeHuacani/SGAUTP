﻿using SGA.App;
using SGA.App.Services;
using SGA.Domain.Interfaces;
using SGA.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using SGA.App.Interfaces;

namespace SGA.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //SGA.Application
            //services.AddScoped<IBookService, BookService>();

            //services.AddScoped<IUserAccountService, UserAccountsService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ICargoService, CargoService>();
            services.AddScoped<IAreaService, AreaService>();

            //SGA.Domain.Interfaces |  SGA.Infra.Data.Repositories
            //services.AddScoped<IBookRepository, BookRepository>();
            //services.AddScoped<IUserAccountRepository,UserAccountRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IAreaRepository, AreaRepository>();
            //INFO

            //Transient objects are always different; a new instance is provided to every controller and every service.

            //Scoped objects are the same within a request, but different across different requests.

            //Singleton objects are the same for every object and every request.



            //In.NET's dependency injection there are three major lifetimes:

            //Singleton which creates a single instance throughout the application.It creates the instance for the first time and reuses the same object in the all calls.

            //Scoped lifetime services are created once per request within the scope.It is equivalent to a singleton in the current scope.For example, in MVC it creates one instance for each HTTP request, but it uses the same instance in the other calls within the same web request.

            //Transient lifetime services are created each time they are requested.This lifetime works best for lightweight, stateless services.


            //Further Reading  https://stackoverflow.com/questions/38138100/addtransient-addscoped-and-addsingleton-services-differences


        }
    }
}

