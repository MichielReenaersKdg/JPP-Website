using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JPP.DAL.EF
{


    [DbConfigurationType(typeof(EFDbConfiguration))]
    public class EFDbContext : DbContext
    {


        public EFDbContext()
            : base("DataConnection")
        {

       

       }


        //public DbSet<Bericht> berichten { get; set; }
        //public DbSet<Recensie> recensies { get; set; }
        //public DbSet<Contactpersoon> contactpersonen { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // 'Bericht.Id' as unique identifier
            //modelBuilder.Entity<Bericht>().HasKey(b => b.id);

            // 'Recensie.Id' as unique identifier
            //modelBuilder.Entity<Recensie>().HasKey(r => r.id);

            // 'Contactpersoon.Id' as unique identifier
            //modelBuilder.Entity<Contactpersoon>().HasKey(c => c.id);
           
        }
    }
}
