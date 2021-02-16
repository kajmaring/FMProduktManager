using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FulfilmentOrder
    {
        public int InternalId { get; set; }
        public int CompanyInternalId { get; set; }
        public string DeliveryNoteId { get; set; }
        public int? CustomerInternalId { get; set; }
        public int? WarehouseInternalId { get; set; }
        public int? UserInternalId { get; set; }
        public int SalesOrderInternalId { get; set; }
        public int? DeliveryNoteInternalId { get; set; }
        public string Status { get; set; }
        public string CurrencyIso { get; set; }
        public string SalesOrderId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? PrintingDate { get; set; }
        public DateTime? MailingDate { get; set; }
        public DateTime? FaxingDate { get; set; }
        public DateTime? ApiShippingDate { get; set; }
        public DateTime? InProcessDate { get; set; }
        public string DeliveryProperty { get; set; }
        public string SalesOrderText { get; set; }
        public string OperationId { get; set; }
    }
}
