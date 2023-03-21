using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.Abstract
{
    public interface IUserService
    {
         User Add(User user);
         User Update(User user);
         void Delete(User user);
         List<User> GetAll();
         User GetById(Expression<Func<User, bool>> filter);
        
    }
}
