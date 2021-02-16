using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TOauthConfig
    {
        public TOauthConfig()
        {
            TOauthToken = new HashSet<TOauthToken>();
        }

        public string CId { get; set; }
        public string CName { get; set; }
        public byte NFlow { get; set; }
        public string CAuthorize { get; set; }
        public string CToken { get; set; }
        public string CClientId { get; set; }
        public string CClientCallback { get; set; }
        public string CClientSecret { get; set; }
        public string CScopes { get; set; }

        public virtual ICollection<TOauthToken> TOauthToken { get; set; }
    }
}
