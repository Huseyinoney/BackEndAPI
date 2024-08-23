using BackEndAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Domain.Entities
{
    public class Entity : BaseEntity
    {
        public Entity()
        {
            
        }
        public Entity(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public  int Id { get; set; }
        public  string Name { get; set; }
    }
}
