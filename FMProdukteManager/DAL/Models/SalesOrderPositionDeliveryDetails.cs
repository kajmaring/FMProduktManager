﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SalesOrderPositionDeliveryDetails
    {
        public int? SalesOrderPositionInternalId { get; set; }
        public decimal? Quantity { get; set; }
        public string BatchNumber { get; set; }
        public DateTime? BestBeforeDate { get; set; }
        public string SerialNumber { get; set; }
    }
}
