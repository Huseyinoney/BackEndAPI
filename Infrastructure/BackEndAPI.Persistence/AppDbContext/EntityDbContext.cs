using BackEndAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Persistence.AppDbContext
{
    public class EntityDbContext : DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> options) : base(options)
        {  
        }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
