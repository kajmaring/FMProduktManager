using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVorgangsstatus
    {
        public int KVorgangsstatus { get; set; }
        public string CName { get; set; }
        public byte? NAngebot { get; set; }
        public byte? NAuftrag { get; set; }
        public byte? NRechnung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
