using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TCustomerQuery
    {
        public TCustomerQuery()
        {
            TCustomerQueryRecht = new HashSet<TCustomerQueryRecht>();
            TCustomerQueryUser = new HashSet<TCustomerQueryUser>();
        }

        public int KCustomerQuery { get; set; }
        public string CName { get; set; }
        public string CQueryText { get; set; }
        public int KKontext { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TCustomerQueryRecht> TCustomerQueryRecht { get; set; }
        public virtual ICollection<TCustomerQueryUser> TCustomerQueryUser { get; set; }
    }
}
