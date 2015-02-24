using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DBModels;

namespace DAL
{
    public class ZooContext : DbContext, IDisposable
    {
        public ZooContext()
            : base("Zoo")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Zoo> Zoos { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<ZooCity> ZooCities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
