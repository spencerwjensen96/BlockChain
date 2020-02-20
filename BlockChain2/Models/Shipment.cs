using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlockChain2.Models;

namespace BlockChain2.Models
{
    public class Shipment
    {
        public string shipmentID { get; set; }
        public string destAddress { get; set; }
        public string estDeliveryDate { get; set; }
        public DeliveryService deliveryService { get; set; }
        public MovementStatus movementStatus { get; set; }
        public bool signatureRequired  { get; set; }
        public string weight  { get; set; }
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