using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VTrackAndTraceConfigurations
    {
        public int KVersandArt { get; set; }
        public string CName { get; set; }
        public int? NTrackAndTraceProviderType { get; set; }
        public byte? NIsEnabled { get; set; }
    }
}
