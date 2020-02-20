using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    public class Permission
    {
        [Key]
        public int permissionID { get; set; }
        [Required]
        public string permission { get; set; }
    }
}