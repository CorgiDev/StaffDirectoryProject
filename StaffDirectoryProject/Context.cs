using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorgiDev.StaffDirectoryProject
{
    public class Context : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}