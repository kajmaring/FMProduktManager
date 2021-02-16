using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TUserControlSetting
    {
        public int KBenutzer { get; set; }
        public string CName { get; set; }
        public string CNameTopLevelControl { get; set; }
        public byte NSetting { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
