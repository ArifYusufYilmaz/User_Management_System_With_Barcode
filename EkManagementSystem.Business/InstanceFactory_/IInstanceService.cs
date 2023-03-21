using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.Qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.InstanceFactory_
{
    public interface IInstanceService
    {
        IUserService GetUserService();
        IExternalFileUserService GetExcelUserService();
        IQrGenerator GetQrGeneratorService();

    }
}
