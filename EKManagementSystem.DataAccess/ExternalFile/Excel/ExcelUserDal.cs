using EKManagementSystem.DataAccess.Abstract;
using EkUserManagementSystem.Entities;
using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKManagementSystem.DataAccess.ExternalFile.Excel
{
    public class ExcelUserDal : IExcelUserDal
    {
        public List<User> GetAll(string filePath)
        {
            var users = new ExcelMapper(filePath).Fetch<User>();

            return users.ToList();


        }


    }
}
