﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InvoiceCorrectionPositionConfiguration
    {
        public int InternalId { get; set; }
        public int? ConfigurationValueInternalId { get; set; }
        public int InvoiceCorrectionPositionInternalId { get; set; }
        public int? ProductInternalId { get; set; }
        public decimal AdditionalNetPrice { get; set; }
        public string ValueText { get; set; }
        public string Name { get; set; }
        public int? ConfigurationInternalId { get; set; }
    }
}
