using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonComboboxImage
    {
        public int KImage { get; set; }
        public string CEnumToString { get; set; }
        public string CPk { get; set; }
        public byte[] OImage { get; set; }
        public string CText { get; set; }
    }
}
