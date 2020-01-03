using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOpdrachtVersie2
{
    public class OpdrachtDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        static OpdrachtDbContext()
        {
            Database.SetInitializer(new OpdrachtDbSeeder());
        }

        public OpdrachtDbContext() : base("OpdrachtDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}