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
        public Item(int id, string name, string num, int q, string[] lst)
        {
            itemID = id;
            itemName = name;
            serialNumber = num;
            quantityOfItem = q;
            certs = lst.ToList();
        }
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
