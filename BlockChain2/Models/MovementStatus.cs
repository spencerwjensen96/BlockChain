using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlockChain2.Models
{
    public class MovementStatus
    {
        enum MovementStatuses
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
        }
    }
}
