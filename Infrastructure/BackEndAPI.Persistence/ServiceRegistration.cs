using BackEndAPI.Application.Repositories;
using BackEndAPI.Application.Services;
using BackEndAPI.Persistence.AppDbContext;
using BackEndAPI.Persistence.Repositories;
using BackEndAPI.Persistence.Services;
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
            services.AddDbContext<EntityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlServer")));
            services.AddScoped<IEntityService, EntityService>();
            services.AddScoped<IEntityRepository, EntityRepository>();
        }
    }
}
