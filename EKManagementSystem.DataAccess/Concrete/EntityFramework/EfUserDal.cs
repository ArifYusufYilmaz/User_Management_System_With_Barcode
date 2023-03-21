using EkManagementSystem.Core.DataAccess.EntityFramework;
using EKManagementSystem.DataAccess.Abstract;
using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKManagementSystem.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal :EfEntityRepositoryBase<User, EkManagementSystemContext>, IUserDal
    {
        
    }
}
