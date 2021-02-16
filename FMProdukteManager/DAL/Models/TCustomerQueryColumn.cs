using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TCustomerQueryColumn
    {
        public int KCustomerQueryColumn { get; set; }
        public int KCustomerQueryUser { get; set; }
        public int NSqlIndex { get; set; }
        public int NGridIndex { get; set; }
        public int NWidth { get; set; }

        public virtual TCustomerQueryUser KCustomerQueryUserNavigation { get; set; }
    }
}
