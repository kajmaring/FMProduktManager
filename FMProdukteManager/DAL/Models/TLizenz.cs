using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLizenz
    {
        public string CAuthId { get; set; }
        public string CAuthToken { get; set; }
        public byte[] BLizenzen { get; set; }
        public byte[] BSignatur { get; set; }
        public DateTime? DDatum { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
