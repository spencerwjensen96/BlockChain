using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    [Table("Facilities")]
    public class Facility : User
    {
        [Key]
        public string facilityID { get; set; }
        [Required]
        public string facilityName { get; set; }
        [Required]
        public string address1 { get; set; }
        public string address2 { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string zipCode { get; set; }
        public Shipment incomingShipment { get; set; }
        public List<Shipment> currentShipments { get; set; }
    }
}
 