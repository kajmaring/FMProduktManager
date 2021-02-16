using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PickListSalesOrderBillToAddress
    {
        public int PickListSalesOrderInternalId { get; set; }
        public int? CustomerInternalId { get; set; }
        public string Company { get; set; }
        public string Salutation { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string CompanySupplement { get; set; }
        public string AddressSupplement { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public string Fax { get; set; }
        public string State { get; set; }
        public string CountryIso { get; set; }
        public string CustomerNumber { get; set; }
        public string ValueAddedTaxId { get; set; }
    }
}
