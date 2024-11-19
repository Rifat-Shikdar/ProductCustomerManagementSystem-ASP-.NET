using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCustomerManagementSystem.DTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public System.DateTime DateJoined { get; set; }
    }
}