using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.Concrete.ExternalFileManager;
using EkManagementSystem.Business.Concrete.Manager;
using EkManagementSystem.Business.Qr;
using EKManagementSystem.DataAccess.Abstract;
using EKManagementSystem.DataAccess.Concrete;
using EKManagementSystem.DataAccess.Concrete.EntityFramework;
using EKManagementSystem.DataAccess.ExternalFile.Excel;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<IExternalFileUserService>().To<ExternalFileUserManager>().InSingletonScope();
            Bind<IExcelUserDal>().To<ExcelUserDal>().InSingletonScope();

            Bind<IQrGenerator>().To<QrGenerator>().InSingletonScope();
        }
    }
}
