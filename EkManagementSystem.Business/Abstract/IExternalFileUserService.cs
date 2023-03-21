using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.Abstract
{
    public interface IExternalFileUserService
    {
        void AddAllUsers(IUserService userService, List<User> users);
        List<User> GetAll(string filePath);
    }
}
