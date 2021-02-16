using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TCryptoVault
    {
        public int KCryptoVault { get; set; }
        public int NSlotId { get; set; }
        public byte[] BDaten { get; set; }
        public byte[] BIv { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
