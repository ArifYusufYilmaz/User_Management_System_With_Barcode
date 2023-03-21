using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKManagementSystem.DataAccess.ExternalFile
{
    public interface IExternalFileDal<TEntity>
    {
       //  string FilePath { get; set; }
         List<TEntity> GetAll(string filePath);
    }
}
