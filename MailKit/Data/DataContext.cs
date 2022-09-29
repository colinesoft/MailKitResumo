using MailKit.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailKit.Data
{
    public class DataContext: DbContext
    {
        public DataContext():base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TSYSTEMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            //Database.SetInitializer(new DbInitializer());
        }

        public DbSet<RegistroEntity> Registros { get; set; }
    }
}
