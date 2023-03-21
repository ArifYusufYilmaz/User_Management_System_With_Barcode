
using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.DependencyResolvers.Ninject;
using EKManagementSystem.DataAccess.Concrete;
using System;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserService _userService = InstanceFactory.GetInstance<IUserService>();
            _userService.GetAll();
            
        }
    }
}
