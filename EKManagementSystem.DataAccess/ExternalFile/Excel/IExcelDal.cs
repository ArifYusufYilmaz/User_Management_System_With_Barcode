using EKManagementSystem.DataAccess.ExternalFile;
using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKManagementSystem.DataAccess.ExternalFile.Excel
{
    public interface IExcelDal<TEntity> : IExternalFileDal<TEntity>
    {
       // List<User> GetAllWithExcelMapper();
    }
}
