using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstTest
{
    class Person : DbContext
    {
        public Person() : base("People") { }
        

        public DbSet<Users> User { get; set; }

    }
}
