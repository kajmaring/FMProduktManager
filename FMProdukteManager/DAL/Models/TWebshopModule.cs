using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWebshopModule
    {
        public string CApikey { get; set; }
        public string CLizenzkey { get; set; }
        public string CName { get; set; }
        public string CId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
