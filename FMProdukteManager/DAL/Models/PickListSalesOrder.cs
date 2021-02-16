using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PickListSalesOrder
    {
        public int InternalId { get; set; }
        public string SalesOrderNumber { get; set; }
        public string Comment { get; set; }
        public string ExternalSalesOrderNumber { get; set; }
        public string CustomerSalesOrderNumber { get; set; }
    }
}
