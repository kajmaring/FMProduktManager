using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TUserLayout
    {
        public int KUserLayout { get; set; }
        public int KBenutzer { get; set; }
        public string CName { get; set; }
        public string CWert { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
