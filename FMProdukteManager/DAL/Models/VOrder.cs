using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VOrder
    {
        public int KOrder { get; set; }
        public int? KInvoice { get; set; }
        public int? KBillToAddress { get; set; }
        public int KShipToAddress { get; set; }
        public string CInvoiceNumber { get; set; }
        public string COrderNumber { get; set; }
        public string CExternalOrderNumber { get; set; }
        public string CDescriptionType { get; set; }
        public string CShippingInfo { get; set; }
        public string CCurrencyIso { get; set; }
        public string CNote { get; set; }
        public DateTime? DCreationDate { get; set; }
        public DateTime? DShippingDate { get; set; }
        public string CComment { get; set; }
        public string CLanguageIso { get; set; }
        public string CShippingName { get; set; }
        public string CPaymentMethodName { get; set; }
        public string CCustomerNumber { get; set; }
        public string CShippingAddressName { get; set; }
        public string CBillingAddressName { get; set; }
        public bool? NChangeable { get; set; }
        public string CShippingAddressCompany { get; set; }
        public string CBillingAddressCompany { get; set; }
        public string CTaxId { get; set; }
    }
}
