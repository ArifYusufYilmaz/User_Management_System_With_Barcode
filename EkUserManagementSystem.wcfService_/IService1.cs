using EkUserManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EkUserManagementSystem.wcfService_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Data/{value}/")]
        string GetData(string value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "composites/composite/{compositeId}",

            BodyStyle = WebMessageBodyStyle.Bare)]
        CompositeType GetCompositeById(string compositeId);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "users/all")]
        List<User> GetUsers();

        [OperationContract]
        [WebInvoke(Method ="POST", ResponseFormat =WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate ="users/user/{userId}", BodyStyle =WebMessageBodyStyle.Bare)]
        User GetUserWithPostMethod(string userId);

        [OperationContract]
        [WebInvoke(Method = "POST" ,
            RequestFormat = WebMessageFormat.Json, 
            ResponseFormat =WebMessageFormat.Json,
            UriTemplate = "users/create/",
            BodyStyle =WebMessageBodyStyle.Bare)]
        User Add(User user);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "composite/new",

            BodyStyle = WebMessageBodyStyle.Bare)]
        CompositeType AddComposite(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public int compositeId { get; set; }
        [DataMember]
        public string compositeName { get; set; }
    }
}
