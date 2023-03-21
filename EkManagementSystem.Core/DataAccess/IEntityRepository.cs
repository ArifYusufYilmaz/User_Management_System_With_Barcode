using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(Expression<Func<T, bool>> filter );
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
