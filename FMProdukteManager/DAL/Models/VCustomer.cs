using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VCustomer
    {
        public int KId { get; set; }
        public string CCustomerNumber { get; set; }
        public string CFirstName { get; set; }
        public string CLastName { get; set; }
        public string CTitle { get; set; }
        public string CCompany { get; set; }
        public string CAddress { get; set; }
        public string CAddressSupplement { get; set; }
        public string CCity { get; set; }
        public string CPostalCode { get; set; }
        public string CState { get; set; }
        public string CCountry { get; set; }
        public string CPhone { get; set; }
        public string CEmailAddress { get; set; }
        public int? KCustomerGroupId { get; set; }
        public string CSalutation { get; set; }
        public string CDateOfBirth { get; set; }
        public decimal FDiscount { get; set; }
        public string CFederalTaxId { get; set; }
        public byte[] BLastChanged { get; set; }
        public int? KShop { get; set; }
        public DateTime? DLastModified { get; set; }
        public DateTime? DActive { get; set; }
        public DateTime? DInactive { get; set; }
    }
}
