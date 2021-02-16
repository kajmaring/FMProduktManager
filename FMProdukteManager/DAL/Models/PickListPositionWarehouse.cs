﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PickListPositionWarehouse
    {
        public int InternalId { get; set; }
        public int PickListInternalId { get; set; }
        public int? WarehouseInternalId { get; set; }
        public int? GoodsReceiptInternalId { get; set; }
        public decimal? Quantity { get; set; }
        public int SalesOrderPositionInternalId { get; set; }
        public int? PickListPositionStatusInternalId { get; set; }
        public int? ProductInternalId { get; set; }
        public int? BinLocationInternalId { get; set; }
        public string Status { get; set; }
        public string BinLocationName { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public int? SerialnumberInternalId { get; set; }
        public string Serialnumber { get; set; }
        public DateTime? Sled { get; set; }
        public string Batchnumber { get; set; }
        public string Ean { get; set; }
    }
}
