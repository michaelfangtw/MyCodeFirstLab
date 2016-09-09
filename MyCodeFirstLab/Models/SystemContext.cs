using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeFirstLab.Models
{
    
        public class SystemContext : DbContext
        {
            public DbSet<User> SystemUsers { get; set; }
            public DbSet<Role> SystemRoles { get; set; }

            public SystemContext()
                : base("name=DefaultConnection")
            {

            }
        }
}
