using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    public class Shipment
    {
        [Key]
        public string shipmentID { get; set; }
        [Required]
        public string destAddress { get; set; }
        [Required]
        public string estDeliveryDate { get; set; }
        [Required]
        public DeliveryService deliveryService { get; set; }
        [Required]
        public MovementStatus movementStatus { get; set; }
        [Required]
        public bool signatureRequired  { get; set; }
        [Required]
        List<Item> itemsContained { get; set; }
        [Required]
        public string weight  { get; set; }
        [Required]
        public string units  { get; set; }
    }

    /* asset Shipment identified by shipmentID {
    o String shipmentID
    --> Vendor vendor
    --> Purchaser purchaser
    // currentFacility is optional 
    --> Facility currentFacility optional
    o String destAddress
    // Used string because JavaScript's datetime isn't as functional as RegEx in the browser
    o String estDeliveryDate
    // enum of available delivery services
    // look into dynamically adding delivery services to enum in models.cto
    o DeliveryService deliveryService
    // Determines the future route of the package
    // Shipment is created by the first index of this array
    // --This is created in the first send function--
    --> Facility[] travelRoute optional
    o MovementStatus movementStatus
    // Change signature to Boolean in model.cto.js
    o Boolean signature optional
    --> Item[] containedItems
    o String weight
    o String units
}
     * */
}