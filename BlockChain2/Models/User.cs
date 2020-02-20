using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int userID { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public UserType userType { get; set; }
        [Required]
        public string companyName { get; set; }
        [Required]
        public Facility facility { get; set; }
    }
}