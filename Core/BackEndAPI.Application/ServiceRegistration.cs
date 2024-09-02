using AutoMapper;
using BackEndAPI.Application.Mapping;
using BackEndAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application
{
    
    public  static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
           
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            /* services.AddAutoMapper(typeof(UserMapper));
             services.AddAutoMapper(typeof(EntityMapper));*/
           
        }
    }
}
