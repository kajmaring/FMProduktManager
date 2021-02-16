﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VLagerbestandStueckliste
    {
        public int KArtikel { get; set; }
        public string CArtNr { get; set; }
        public int KStueckliste { get; set; }
        public decimal? FLagerbestand { get; set; }
        public decimal? FLagerbestandEigen { get; set; }
        public decimal? FVerfuegbarGesperrt { get; set; }
        public decimal? FZulauf { get; set; }
        public decimal? FAufEinkaufsliste { get; set; }
        public DateTime? DLieferdatum { get; set; }
        public decimal? FVerfuegbar { get; set; }
        public decimal? FAuslieferungGesperrt { get; set; }
    }
}
