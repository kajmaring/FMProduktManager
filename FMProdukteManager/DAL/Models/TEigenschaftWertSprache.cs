using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEigenschaftWertSprache
    {
        public int KEigenschaftWert { get; set; }
        public int KSprache { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
