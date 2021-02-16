using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TCustomerQueryOverviewRecht
    {
        public int KCustomerQueryOverview { get; set; }
        public int KRechtBenutzerGruppe { get; set; }

        public virtual TCustomerQueryOverview KCustomerQueryOverviewNavigation { get; set; }
    }
}
