using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Parcels
    {
        public int InternalId { get; set; }
        public int DeliveryNoteInternalId { get; set; }
        public string IdentCode { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Note { get; set; }
        public decimal Weight { get; set; }
        public string ShippingServiceProviderName { get; set; }
        public DateTime? ShippingDate { get; set; }
        public string ShipmentReference { get; set; }
        public string CustomerReference { get; set; }
        public string TrackingUrl { get; set; }
        public bool? IsShippingParcel { get; set; }
        public int? ShippingMethodInternalId { get; set; }
    }
}
