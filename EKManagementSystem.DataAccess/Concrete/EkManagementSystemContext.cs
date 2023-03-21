using EKManagementSystem.DataAccess.Concrete.EntityFramework.Mappings;
using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKManagementSystem.DataAccess.Concrete
{
    public class EkManagementSystemContext:DbContext
    {
        public EkManagementSystemContext()
        {
            //Database.SetInitializer<EkManagementSystemContext>(null);  // there is no available db.
            
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
