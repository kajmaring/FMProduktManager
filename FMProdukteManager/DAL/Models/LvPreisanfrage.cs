using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvPreisanfrage
    {
        public int KLieferantenBestellung { get; set; }
        public string CPreisanfrage { get; set; }
        public string CLieferant { get; set; }
        public string CLieferantFirmenZusatz { get; set; }
        public string CLieferantennummer { get; set; }
        public string CLieferantEigeneKundennummer { get; set; }
        public DateTime? DErstellt { get; set; }
        public DateTime? DGedruckt { get; set; }
        public DateTime? DGemailt { get; set; }
        public DateTime? DGefaxt { get; set; }
        public string CKommentar { get; set; }
        public byte NBestaetigt { get; set; }
        public string CLieferadresseFirma { get; set; }
        public string CLieferadresseVorname { get; set; }
        public string CLieferadresseName { get; set; }
        public string CRechnungsadresseFirma { get; set; }
        public string CRechnungsadresseVorname { get; set; }
        public string CRechnungsadresseName { get; set; }
        public string CLieferadressePlz { get; set; }
        public string CLieferadresseOrt { get; set; }
        public string CLieferadresseLand { get; set; }
        public string CLieferadresseStrasse { get; set; }
        public string CLieferadresseMail { get; set; }
    }
}
