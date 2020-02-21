using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    [Table("ShipmentItem")]
    public class ShipmentItem
    {
        [Key]
        public int shipmentItemID { get; set; }
        [Required]
        public Shipment shipment { get; set; }
        [Required]
        public Item item { get; set; }
    }
}