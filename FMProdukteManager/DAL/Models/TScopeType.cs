using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TScopeType
    {
        public TScopeType()
        {
            TVorgangType = new HashSet<TVorgangType>();
        }

        public int KScopeType { get; set; }
        public string CId { get; set; }

        public virtual ICollection<TVorgangType> TVorgangType { get; set; }
    }
}
