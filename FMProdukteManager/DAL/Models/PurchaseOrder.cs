using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PurchaseOrder
    {
        public int InternalId { get; set; }
        public int SupplierInternalId { get; set; }
        public int? PurchaseOrderBillToAddressInternalId { get; set; }
        public int? PurchaseOrderSupplierAddressInternalId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? PrintingDate { get; set; }
        public DateTime? MailingDate { get; set; }
        public DateTime? FaxingDate { get; set; }
        public DateTime? ExportingDate { get; set; }
        public string CurrencyIso { get; set; }
        public string PrintingNote { get; set; }
        public int? CompanyInternalId { get; set; }
        public int? WarehouseInternalId { get; set; }
        public int? CustomerInternalId { get; set; }
        public string OwnPurchaseOrderId { get; set; }
        public string ReferenceSalesOrderId { get; set; }
        public int? PurchaseOrderSupplierInternalId { get; set; }
        public int? UserInternalId { get; set; }
        public int DeliveryNoteInternalId { get; set; }
        public decimal CurrencyFactor { get; set; }
        public string Status { get; set; }
        public bool? DifferentAddresses { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? TotalGrossPriceDiscount { get; set; }
        public decimal? TotalNetPriceDiscount { get; set; }
        public decimal? TotalVatprice { get; set; }
        public string OperationId { get; set; }
    }
}
