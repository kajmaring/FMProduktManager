using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayZahlungOut
    {
        public int? KEbayCheckout { get; set; }
        public string DDatum { get; set; }
        public decimal FBetrag { get; set; }
    }
}
