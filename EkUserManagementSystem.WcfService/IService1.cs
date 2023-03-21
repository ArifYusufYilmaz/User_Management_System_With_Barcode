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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "SayHello/{value}")]
        string GetData(string value);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "SayHelloWithValue/{value}")]
        string GetDataWithValue(string value);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetModelById/{compositeId}")]
        CompositeType GetDataUsingDataContract(string compositeId);

        [OperationContract]
        string GetDataWithString(string value1, string value2);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate ="GetAllUsers/")]
        List<User> GetAllUsers();


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public string compositeId { get; set; }
        [DataMember]
        public string compositeName { get; set; }
        [DataMember]
        public string compositeDescription { get; set; }
    }
}
