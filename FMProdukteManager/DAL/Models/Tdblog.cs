using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tdblog
    {
        public string CKategorie { get; set; }
        public string CException { get; set; }
        public string CInfo { get; set; }
        public DateTime? DZeit { get; set; }
    }
}
