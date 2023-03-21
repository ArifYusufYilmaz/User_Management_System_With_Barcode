using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace EkUserManagementSystem.WcfService.App_Code
{
    [ServiceContract]
    public interface IUserWcfService
    {
        [OperationContract]
        [WebGet(ResponseFormat =WebMessageFormat.Json, UriTemplate ="wcf/v1/user/{id}")]
         User GetById(string id);
    }
}