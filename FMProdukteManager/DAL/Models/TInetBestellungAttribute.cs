using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TInetBestellungAttribute
    {
        public int KInetBestellungAttribute { get; set; }
        public int KInetBestellung { get; set; }
        public int KShop { get; set; }
        public string CName { get; set; }
        public string CValue { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
