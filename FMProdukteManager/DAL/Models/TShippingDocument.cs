using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShippingDocument
    {
        public int KShippingDocument { get; set; }
        public int KVersand { get; set; }
        public byte NTyp { get; set; }
        public byte[] BData { get; set; }
        public string CHash { get; set; }
        public DateTime DDate { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
