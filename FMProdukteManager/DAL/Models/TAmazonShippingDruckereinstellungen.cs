using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAmazonShippingDruckereinstellungen
    {
        public int KAmazonShippingDruckereinstellungen { get; set; }
        public int? KVersandart { get; set; }
        public string CRechnername { get; set; }
        public int? KBenutzer { get; set; }
        public string CDruckername { get; set; }
        public int? NPageScaling { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
