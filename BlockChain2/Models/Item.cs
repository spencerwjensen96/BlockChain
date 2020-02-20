using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlockChain2.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public string itemID { get; set; }
        [Required]
        public string itemName { get; set; }
        [Required]
        public string serialNumber { get; set; }
        [Required]
        public int quantityOfItem { get; set; }
        [Required]
        public Facility facility { get; set; }
    }
}
