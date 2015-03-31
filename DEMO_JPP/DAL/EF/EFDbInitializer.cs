using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;


namespace JPP.DAL.EF
{
    public class EFDbInitializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {

           
           
        }
    }
   
}
