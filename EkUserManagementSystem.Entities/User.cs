using EkManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkUserManagementSystem.Entities
{
    public class User : IEntity
    {
        public long UserId { get; set; }
        public long IdCardNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return UserId +" "+IdCardNo + " " + FirstName + " " + LastName + " " + Email + " " + PhoneNumber + " " + Address;
            
        }
    }
}
