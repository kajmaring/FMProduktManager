using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfListviewColors
    {
        public int NColorId { get; set; }
        public int NSubColorId { get; set; }
        public int NListViewId { get; set; }
        public string CRgb { get; set; }
    }
}
