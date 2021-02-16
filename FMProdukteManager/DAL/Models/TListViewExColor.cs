using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TListViewExColor
    {
        public int KListViewExColor { get; set; }
        public int KBenutzer { get; set; }
        public int KBenutzerAdmin { get; set; }
        public int NListViewId { get; set; }
        public string CRechnername { get; set; }
        public int NColorId { get; set; }
        public int NSubColorId { get; set; }
        public string CRgb { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
