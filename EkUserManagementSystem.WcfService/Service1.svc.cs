using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.InstanceFactory_;
using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EkUserManagementSystem.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string GetDataWithValue(string value)
        {
            return "this time you entered : " + value;
        }
        
        public CompositeType GetDataUsingDataContract(string compositeId)
        {
            CompositeType composite = new CompositeType();
            composite.compositeId =  compositeId;
            composite.compositeName = "my name is composite";
            composite.compositeDescription = "description for composite";
            return composite;
        }

        
        public List<User> GetAllUsers()
        {
            IInstanceService instanceService = new InstanceManager();
            IUserService userService = instanceService.GetUserService();
            var result = userService.GetAll();

            return result;          //  throw new NotImplementedException();
        }

        public string GetDataWithString(string value1, string value2)
        {
            return value1 + value2;
        }

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{

        //    return composite;
        //}

    }
}
