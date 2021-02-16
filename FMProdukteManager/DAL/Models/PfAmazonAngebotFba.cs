﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonAngebotFba
    {
        public string CSellerSku { get; set; }
        public int? KUser { get; set; }
        public int? NQuantity { get; set; }
        public string CConditionType { get; set; }
        public string CWarehouseConditionType { get; set; }
        public int? NQtyWarehouse { get; set; }
        public int? NQtyUnsellable { get; set; }
        public int? NQtyReserved { get; set; }
        public int? NQtyTotal { get; set; }
        public int? NQtyInboundWorking { get; set; }
        public int? NQtyInboundShipped { get; set; }
        public int? NQtyReceiving { get; set; }
        public decimal? FVolume { get; set; }
        public string CFnsku { get; set; }
    }
}
