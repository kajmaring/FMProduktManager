using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PurchaseOrderSupplier
    {
        public int InternalId { get; set; }
        public int SupplierInternalId { get; set; }
        public string Company { get; set; }
        public string FirmenSupplement { get; set; }
        public string Address { get; set; }
        public string AddressSupplement { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryIso { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public string ContactSalutation { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
    }
}
