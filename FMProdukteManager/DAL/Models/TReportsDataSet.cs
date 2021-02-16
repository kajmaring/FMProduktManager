using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TReportsDataSet
    {
        public int? KReports { get; set; }
        public string CDataSet { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
