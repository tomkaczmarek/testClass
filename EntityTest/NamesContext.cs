﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class NamesContext : DbContext
    {
        public DbSet<Names> Names { get; set; }
        public DbSet<Subject> Subject { get; set; }
    }
}
