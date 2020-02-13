using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlockChain2.Models
{
    public class Facility : User
    {
        public string facilityName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
    }

    /*
     * 
participant Facility extends User {
  o String facilityName
  o String Address1
  o String Address2 optional
  o String City
  o String State
  o String Country
  o String ZipCode
  // needs to be changed to -->
  o Shipment[] incomingShipments optional
  o Shipment[] currentShipments optional
}*/
}
 