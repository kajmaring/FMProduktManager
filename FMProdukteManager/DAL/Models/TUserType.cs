using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TUserType
    {
        public TUserType()
        {
            TVorgangType = new HashSet<TVorgangType>();
        }

        public int KUserType { get; set; }
        public string CId { get; set; }

        public virtual ICollection<TVorgangType> TVorgangType { get; set; }
    }
}
