using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    [Table("MovementStatus")]
    public class MovementStatus
    {
        [Key]
        public int movementStatusID { get; set; }
        [Required]
        public string status { get; set; }
/*  enum MovementStatuses
    {
        IN_VENDOR_POSSESSION,
        IN_FACILITY,
        IN_TRANSIT,
        DELIVERED,
        DAMAGED,
        LOST,
        UNDER_REVIEW,
        SIEZED,
        OUT_FOR_DELIVERY
    }*/
    }
}
