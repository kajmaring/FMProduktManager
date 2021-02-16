using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VRetourePositionenExportData
    {
        public int KRmretoure { get; set; }
        public decimal Anzahl { get; set; }
        public string Beschreibung { get; set; }
        public decimal? PreisGesamt { get; set; }
        public decimal? GewichtGesamt { get; set; }
    }
}
