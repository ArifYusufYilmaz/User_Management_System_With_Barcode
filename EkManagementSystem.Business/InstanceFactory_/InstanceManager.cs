using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.DependencyResolvers.Ninject;
using EkManagementSystem.Business.Qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.InstanceFactory_
{
    public class InstanceManager :IInstanceService
    {
        private IUserService _userService;
        private IExternalFileUserService _excelUserService;
        private IQrGenerator _qrGenerator;
        public InstanceManager()
        {

        }
        public IUserService GetUserService()
        {
            
           return _userService = InstanceFactory.GetInstance<IUserService>();
         
        }
        public IExternalFileUserService GetExcelUserService()
        {
           return _excelUserService = InstanceFactory.GetInstance<IExternalFileUserService>();
        }

       
        public IQrGenerator GetQrGeneratorService()
        {
            return _qrGenerator = InstanceFactory.GetInstance<IQrGenerator>();
        }
    }
}
