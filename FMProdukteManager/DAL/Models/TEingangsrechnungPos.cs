﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEingangsrechnungPos
    {
        public int KEingangsrechnungPos { get; set; }
        public int? KEingangsrechnung { get; set; }
        public int? KLieferantenbestellung { get; set; }
        public int? KArtikel { get; set; }
        public string CArtNr { get; set; }
        public string CLieferantenArtNr { get; set; }
        public string CName { get; set; }
        public string CLieferantenBezeichnung { get; set; }
        public string CEinheit { get; set; }
        public string CHinweis { get; set; }
        public decimal FMenge { get; set; }
        public decimal FEknetto { get; set; }
        public decimal FMwSt { get; set; }
        public byte? NPosTyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
