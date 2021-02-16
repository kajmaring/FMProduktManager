using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVorlagenset
    {
        public TVorlagenset()
        {
            TVorlage = new HashSet<TVorlage>();
            TVorlagensetEinstellung = new HashSet<TVorlagensetEinstellung>();
        }

        public int KVorlagenset { get; set; }
        public int NVorlagensettyp { get; set; }
        public string CName { get; set; }
        public bool NIstStandard { get; set; }
        public int NFlags { get; set; }
        public byte[] BRowversion { get; set; }
        public bool NIstGlobal { get; set; }

        public virtual ICollection<TVorlage> TVorlage { get; set; }
        public virtual ICollection<TVorlagensetEinstellung> TVorlagensetEinstellung { get; set; }
    }
}
