﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShippingMethodMapping
    {
        public int KShippingMethodMapping { get; set; }
        public byte NType { get; set; }
        public string CShippingMethodId { get; set; }
        public byte NDefault { get; set; }
        public byte NActive { get; set; }
        public int KVersandart { get; set; }
        public int? KKunde { get; set; }
        public int? KWarenlager { get; set; }
        public int NShippingType { get; set; }

        public virtual Tkunde KKundeNavigation { get; set; }
        public virtual Tversandart KVersandartNavigation { get; set; }
        public virtual TWarenLager KWarenlagerNavigation { get; set; }
    }
}
