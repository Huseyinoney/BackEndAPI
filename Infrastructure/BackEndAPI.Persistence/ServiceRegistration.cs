using BackEndAPI.Application.Repositories;
using BackEndAPI.Application.UnitOfWorks;
using BackEndAPI.Persistence.AppDbContext;
using BackEndAPI.Persistence.Repositories;
using BackEndAPI.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace BackEndAPI.Persistence
{
    public static class ServiceRegistration
    {

        public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext.AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlServer")));
            //services.AddScoped<IEntityRepository, EntityRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();  
        }
    }
}
