using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlockChain2.Models
{
    public class Vendor: User
    {
        public string companyName { get; set; }
        public int MyProperty { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipCode { get; set; }
    }
}