using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TCustomerQueryOverview
    {
        public TCustomerQueryOverview()
        {
            TCustomerQueryOverviewRecht = new HashSet<TCustomerQueryOverviewRecht>();
        }

        public int KCustomerQueryOverview { get; set; }
        public string CName { get; set; }
        public string CQueryText { get; set; }
        public int NTyp { get; set; }
        public int NSort { get; set; }
        public byte[] BRowversion { get; set; }
        public byte[] BIcon { get; set; }
        public int NBereich { get; set; }
        public int? KParent { get; set; }

        public virtual ICollection<TCustomerQueryOverviewRecht> TCustomerQueryOverviewRecht { get; set; }
    }
}
