using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    [Table("UserType")]
    public class UserType
    {
        [Key]
        public int userTypeID { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public ICollection<Permission> permissions { get; set; }
        /*
         * Originator,
         * Vendor,
         * Purchaser?,
         * Admin
         * */
    }
}