using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTrackAndTraceConfiguration
    {
        public int KVersandart { get; set; }
        public int NTrackAndTraceProviderType { get; set; }
        public byte NIsEnabled { get; set; }

        public virtual Tversandart KVersandartNavigation { get; set; }
    }
}
