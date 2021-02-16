using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRmgrund
    {
        public int KRmgrund { get; set; }
        public byte NAktiv { get; set; }
        public string CColor { get; set; }
        public byte NEinschraenkung { get; set; }
        public byte? NWmsVisible { get; set; }
        public int? NSort { get; set; }
        public int NFfncode { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
