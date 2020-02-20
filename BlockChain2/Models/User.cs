using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlockChain2.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string userId { get; set; }
    }
}