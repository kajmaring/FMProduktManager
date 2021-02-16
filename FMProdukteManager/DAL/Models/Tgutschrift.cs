﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tgutschrift
    {
        public int KGutschrift { get; set; }
        public int? KRechnung { get; set; }
        public int? KKunde { get; set; }
        public string CGutschriftNr { get; set; }
        public string CKurzText { get; set; }
        public string CText { get; set; }
        public decimal FPreis { get; set; }
        public decimal FMwSt { get; set; }
        public DateTime? DErstellt { get; set; }
        public string CErloeskonto { get; set; }
        public byte? NErweitert { get; set; }
        public string CWaehrung { get; set; }
        public decimal FFaktor { get; set; }
        public int? KFirma { get; set; }
        public int? KSprache { get; set; }
        public int? KBenutzer { get; set; }
        public string CStatus { get; set; }
        public int? KRechnungsAdresse { get; set; }
        public int? KPlattform { get; set; }
        public string CVersandlandWaehrung { get; set; }
        public decimal FVersandlandWaehrungFaktor { get; set; }
        public DateTime? DDruckdatum { get; set; }
        public DateTime? DMaildatum { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
