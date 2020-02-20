using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    [Table("DeliveryService")]
    public class DeliveryService
    {
        [Key]
        public int deliveryServiceID { get; set; }
        [Required]
        public string deliveryService { get; set; }
        /*enum DeliveryOptions
        {
            JBHunt,
            USPS,
            FedEx,
            UPS,
            DHL
        }*/
    }
}