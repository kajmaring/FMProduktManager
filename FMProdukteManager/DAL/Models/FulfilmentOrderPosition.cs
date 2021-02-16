using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FulfilmentOrderPosition
    {
        public int InternalId { get; set; }
        public int? FulfilmentOrderInternalId { get; set; }
        public string Sku { get; set; }
        public decimal Quantity { get; set; }
        public int? Status { get; set; }
        public string ItemGiftText { get; set; }
        public string ItemNote { get; set; }
        public int? DeliveryNotePositionInternalId { get; set; }
        public string Name { get; set; }
        public int? LanguageInternalId { get; set; }
        public int? Sorting { get; set; }
        public decimal? IndividualWeight { get; set; }
        public decimal? TotalWeight { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }
        public string ItemDescriptionDetailed { get; set; }
        public string ItemDescriptionShort { get; set; }
    }
}
