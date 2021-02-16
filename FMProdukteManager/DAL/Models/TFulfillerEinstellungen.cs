﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFulfillerEinstellungen
    {
        public int KFulfillerEinstellungen { get; set; }
        public int KLieferant { get; set; }
        public int KKunde { get; set; }
        public string CPrefixAbrechnung { get; set; }
        public string CSuffixAbrechnung { get; set; }
        public byte NAbrechnungsZeitraum { get; set; }
        public int KAbrechnung { get; set; }
        public DateTime DAbrechnungInitial { get; set; }
        public DateTime DAbrechnungStart { get; set; }
        public DateTime DAbrechnungEnde { get; set; }
        public int? NBestandserfassungModus { get; set; }
    }
}
