using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayAlienitem
    {
        public int KAlienItem { get; set; }
        public string Title { get; set; }
        public string ItemId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string ListingType { get; set; }
        public int Quantity { get; set; }
        public int QuantityAvailable { get; set; }
        public int? SsBidderCount { get; set; }
        public int? SsBidCount { get; set; }
        public decimal SsCurrentPrice { get; set; }
        public string SsHighBidderUserId { get; set; }
        public decimal StartPrice { get; set; }
        public decimal BuyItNowPrice { get; set; }
        public string CurrencyId { get; set; }
        public string UserId { get; set; }
        public byte? Status { get; set; }
        public int? KEbayuser { get; set; }
        public string Sku { get; set; }
        public decimal Vatpercent { get; set; }
    }
}
