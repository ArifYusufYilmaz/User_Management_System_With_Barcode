using EkManagementSystem.Business.Abstract;
using EKManagementSystem.DataAccess.ExternalFile;
using EKManagementSystem.DataAccess.ExternalFile.Excel;
using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.Concrete.ExternalFileManager
{
    public class ExternalFileUserManager : IExternalFileUserService
    {
        IExcelUserDal _excelUserDal;
        
        public ExternalFileUserManager(IExcelUserDal excelUserDal)
        {
            _excelUserDal = excelUserDal;
        }

        public void AddAllUsers(IUserService userService, List<User> users)
        {
          
            if (!(users.Count > 0))
            {
                //throw sth; 
            }
            foreach (var user in users)
            {
                userService.Add(user);
            }
        }
        
        public List<User> GetAll(string filePath)
        {
            var users = _excelUserDal.GetAll(filePath);
            return users;
        }
    }
}
