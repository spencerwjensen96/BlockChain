using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    [Table("Shipment")]
    public class Shipment
    {
        [Key]
        public int shipmentID { get; set; }

        public Facility destAddress { get; set; }
        public Facility sourceAddress { get; set; }
        public string estDeliveryDate { get; set; }

        [Required]
        public DeliveryService deliveryService { get; set; }
        [Required]
        public MovementStatus movementStatus { get; set; }
        [Required]
        public bool signatureRequired { get; set; }
        [Required]
        public ICollection<Item> itemsContained { get; set; }
        [Required]
        public string weight { get; set; }
        [Required]
        public string units { get; set; }
    }
}