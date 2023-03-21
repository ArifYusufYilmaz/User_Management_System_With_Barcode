using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKManagementSystem.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"User", @"dbo");
            HasKey(x => x.UserId);
            Property(x => x.UserId).HasColumnName("UserId");
            Property(x => x.IdCardNo).HasColumnName("IdCardNo");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber");
            Property(x => x.Address).HasColumnName("Address");

        }
    }
}
