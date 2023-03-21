using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.InstanceFactory_;
using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EkUserManagementSystem.wcfService_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        IInstanceService _instanceService;
        IUserService _userService;
        List<CompositeType> composites = new List<CompositeType>();
        Service1()
        {
            _instanceService = new InstanceManager();
            _userService = _instanceService.GetUserService();
        }
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }
        public List<User> GetUsers()
        {
            return _userService.GetAll();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            return composite;
        }

        public User Add(User user)
        {
            var request = _userService.Add(user);
            return request;
            
        }

        public CompositeType AddComposite(CompositeType composite)
        {
            // convert Stream Data to StreamReader  
            // StreamReader reader = new StreamReader(data);

            // Read StreamReader data as string  
            // string xmlString = reader.ReadToEnd();
            // string returnValue = xmlString;

            // return the XMLString data  
            // return returnValue;
            composites.Add(composite);
            return composite;
            
        }

        public User GetUserWithPostMethod(string id)
        {
            //null check
            
            long _id = Int64.Parse(id);
           var request = _userService.GetById(u=> u.UserId == _id);
            return request;
        }

        public CompositeType GetCompositeById(string compositeId)
        {
            foreach (var _composite in composites)
            {
                if(_composite.compositeId == Int32.Parse(compositeId))
                {
                    return _composite;
                }
            }
            return null; //
        }

      
    }
}
