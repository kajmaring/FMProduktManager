using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TOauthToken
    {
        public int KOauthToken { get; set; }
        public string CConfigId { get; set; }
        public DateTime DValidUntil { get; set; }
        public string CAccessToken { get; set; }
        public string CRefreshToken { get; set; }
        public byte NInvalid { get; set; }

        public virtual TOauthConfig CConfig { get; set; }
    }
}
