using BackEndAPI.Application.Services;
using BackEndAPI.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
          services.AddScoped<ITokenService,TokenService>();
           services.AddHttpContextAccessor();
        }
    }
}
