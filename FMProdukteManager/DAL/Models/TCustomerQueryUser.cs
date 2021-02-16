using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TCustomerQueryUser
    {
        public TCustomerQueryUser()
        {
            TCustomerQueryColumn = new HashSet<TCustomerQueryColumn>();
        }

        public int KCustomerQueryUser { get; set; }
        public int KBenutzer { get; set; }
        public int KCustomerQuery { get; set; }

        public virtual TCustomerQuery KCustomerQueryNavigation { get; set; }
        public virtual ICollection<TCustomerQueryColumn> TCustomerQueryColumn { get; set; }
    }
}
