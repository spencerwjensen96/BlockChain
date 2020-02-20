using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    public class Facility : User
    {
        public string facilityName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipCode { get; set; }
        public Shipment incomingShipment { get; set; }
        public List<Shipment> currentShipments { get; set; }
    }
}
 