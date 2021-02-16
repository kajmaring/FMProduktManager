using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Company
    {
        public int InternalId { get; set; }
        public string CompanyName { get; set; }
        public string ManagingDirector { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
        public string BankName { get; set; }
        public string FederalTaxId { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string AccountHolder { get; set; }
        public string CountryIso { get; set; }
        public string ValueAddedTaxId { get; set; }
        public string CreditorId { get; set; }
        public string PayPalEmail { get; set; }
    }
}
