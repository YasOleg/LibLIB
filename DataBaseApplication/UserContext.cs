﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApplication
{
    class UserContext : DbContext
    {
        public UserContext() : base("DBConnection") {}

        public DbSet<Users> UserSet { get; set; }
    }
}
