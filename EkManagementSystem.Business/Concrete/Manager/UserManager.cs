using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.Validation;
using EkManagementSystem.Core.Validation.FluentValidation;
using EKManagementSystem.DataAccess.Abstract;
using EkUserManagementSystem.Entities;
using IronBarCode; /// to do:  delete!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.Concrete.Manager
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User Add(User user)
        {
            if(user == null)
            {
                 //throw custom exception(user not found excp) if it needs!!
            }
           
            _userDal.Add(user);
            return user;
        }
        public User Update(User user)
        {
            if (user == null)
            {
                // throw user not found excp!!
            }
            return user;
        }
        public void Delete(User user)
        {
            if (user == null)
            {
                // throw user not found excp!!
            }
        }
        public List<User> GetAll()
        {
            
            return _userDal.GetAll();
            
        }
        public User GetById(Expression<Func<User, bool>> filter)
        {
            return _userDal.GetById(filter);
        }
        
    }
}
