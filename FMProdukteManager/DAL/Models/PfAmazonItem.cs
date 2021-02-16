﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonItem
    {
        public int KItem { get; set; }
        public int KGroup { get; set; }
        public int KArtikel { get; set; }
        public int KPlattform { get; set; }
        public int KUser { get; set; }
        public byte NStatus { get; set; }
        public int? NErrorCode { get; set; }
        public string CErrorMessage { get; set; }
        public DateTime? DErrorErstellt { get; set; }
        public string CSku { get; set; }
        public string CErrorHilfeText { get; set; }
        public byte NRemoveBeschreibungsHtml { get; set; }
        public DateTime? DLastTransmission { get; set; }
        public byte NReplaceLineBreaks { get; set; }
    }
}
