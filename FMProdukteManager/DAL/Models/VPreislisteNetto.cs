﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VPreislisteNetto
    {
        public int KArtikel { get; set; }
        public int KKundenGruppe { get; set; }
        public int KShop { get; set; }
        public int NAnzahlAb { get; set; }
        public decimal FNettoPreis { get; set; }
    }
}
