﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VIndividuellePreise
    {
        public int KArtikel { get; set; }
        public int KKundenGruppe { get; set; }
        public int KKunde { get; set; }
        public int KShop { get; set; }
        public int NAnzahlAb { get; set; }
        public decimal FNettoPreis { get; set; }
        public decimal FProzent { get; set; }
    }
}
