using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TXmlgutschriftImport
    {
        public int KXmlgutschriftImport { get; set; }
        public string CText { get; set; }
        public byte? NPlattform { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
