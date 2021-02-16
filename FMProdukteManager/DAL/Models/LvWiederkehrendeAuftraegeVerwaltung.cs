using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvWiederkehrendeAuftraegeVerwaltung
    {
        public int KIntervall { get; set; }
        public int? KBestellung { get; set; }
        public string CAuftragsnummer { get; set; }
        public string CKundenNr { get; set; }
        public string CFirma { get; set; }
        public string CNachname { get; set; }
        public decimal? FWert { get; set; }
        public string CWaehrung { get; set; }
        public byte? NZahlungsziel { get; set; }
        public DateTime? DStartdatum { get; set; }
        public DateTime? DEnddatum { get; set; }
        public short? NTage { get; set; }
        public short? NMonate { get; set; }
        public short? NJahre { get; set; }
        public short? NAmMonatsende { get; set; }
    }
}
