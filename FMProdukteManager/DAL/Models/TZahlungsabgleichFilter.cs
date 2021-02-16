using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZahlungsabgleichFilter
    {
        public int KZahlungsabgleichFilter { get; set; }
        public string CBeschreibung { get; set; }
        public int KZahlungsabgleichModul { get; set; }
        public byte NUmsatzart { get; set; }
        public byte NFilterspalte { get; set; }
        public byte NFilteroperator { get; set; }
        public string CFilterwert { get; set; }
        public byte NAktion { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
