using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVorgangType
    {
        public TVorgangType()
        {
            TVorgang = new HashSet<TVorgang>();
        }

        public int KVorgangType { get; set; }
        public string CId { get; set; }
        public int KUserType { get; set; }
        public int KScopeType { get; set; }
        public string CWawiKeyType { get; set; }
        public string CFfnKeyType { get; set; }

        public virtual TScopeType KScopeTypeNavigation { get; set; }
        public virtual TUserType KUserTypeNavigation { get; set; }
        public virtual ICollection<TVorgang> TVorgang { get; set; }
    }
}
