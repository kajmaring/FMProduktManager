using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tkonfigitempreis
    {
        public int KKonfigitem { get; set; }
        public int KKundengruppe { get; set; }
        public int? KSteuerklasse { get; set; }
        public decimal FPreis { get; set; }
        public int KShop { get; set; }
        public byte? NTyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
