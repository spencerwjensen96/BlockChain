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
        public int itemID { get; set; }
        [Required]
        public string itemName { get; set; }
        [Required]
        public string serialNumber { get; set; }
        [Required]
        public int quantityOfItem { get; set; }

        [Display(Name ="Certifications")]
        public List<string> certs { get;  set; }

        public Facility facility { get; set; }
    }
}
