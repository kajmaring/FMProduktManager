using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDataFeedback
    {
        public int KFeedback { get; set; }
        public int? KEbayUser { get; set; }
        public string CString { get; set; }
    }
}
