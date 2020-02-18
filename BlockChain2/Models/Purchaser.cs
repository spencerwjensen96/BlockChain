using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    public class Purchaser : User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public List<Shipment> incomingShipments { get; set; }
    }
}