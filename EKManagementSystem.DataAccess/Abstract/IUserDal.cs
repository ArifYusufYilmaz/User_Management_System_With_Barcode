using EkManagementSystem.Core.DataAccess;
using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKManagementSystem.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        
    }
}
