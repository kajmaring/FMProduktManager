using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAuthCode
    {
        public int KAuthCode { get; set; }
        public string CName { get; set; }
        public string CAuthToken { get; set; }
        public int? KMandant { get; set; }
        public byte NStatus { get; set; }
    }
}
