﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Domain.Entities
{
    public class Entity
    {
        public  int Id { get; set; }
        public required string Name { get; set; }
    }
}
