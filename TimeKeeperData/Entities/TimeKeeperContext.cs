using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeperData.Entities
{
    class TimeKeeperContext : DbContext
    {
        public TimeKeeperContext() : base("TimeKeeperContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<TimeItem> TimeItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
