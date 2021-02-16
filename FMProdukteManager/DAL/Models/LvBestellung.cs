using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvBestellung
    {
        public int KBestellung { get; set; }
        public string CBestellnummer { get; set; }
        public DateTime? DErstellt { get; set; }
        public int KLieferant { get; set; }
        public string CLieferantName { get; set; }
        public string CLieferantennummer { get; set; }
        public string CLieferantFirmenZusatz { get; set; }
        public string CLieferantEigeneKundennummer { get; set; }
        public int NStatus { get; set; }
        public byte? NManuellAbgeschlossen { get; set; }
        public DateTime? DGemailt { get; set; }
        public DateTime? DGefaxt { get; set; }
        public DateTime? DGedruckt { get; set; }
        public DateTime? DAngemahnt { get; set; }
        public string CInternerKommentar { get; set; }
        public string CFremdbelegnummer { get; set; }
        public byte NBestaetigt { get; set; }
        public DateTime? DLieferdatum { get; set; }
        public string CDruckAnmerkung { get; set; }
        public string CWarenLagerName { get; set; }
        public DateTime? DExportiert { get; set; }
        public string CBenutzerName { get; set; }
        public string CBezugsAuftragsNummer { get; set; }
        public decimal FSummePositionenNetto { get; set; }
        public decimal FSummePositionenBrutto { get; set; }
        public int NAnzahlPositionen { get; set; }
        public decimal FMengeGeliefert { get; set; }
        public decimal FProzentGeliefert { get; set; }
        public decimal FGesamtmenge { get; set; }
        public string CKundenNr { get; set; }
        public string CKundeFirma { get; set; }
        public string CKundeVorname { get; set; }
        public string CKundeName { get; set; }
        public string CLieferadresseFirma { get; set; }
        public string CLieferadresseVorname { get; set; }
        public string CLieferadresseName { get; set; }
        public string CLieferadressePlz { get; set; }
        public string CLieferadresseOrt { get; set; }
        public string CLieferadresseLand { get; set; }
        public string CLieferadresseStrasse { get; set; }
        public string CLieferadresseMail { get; set; }
        public string CRechnungsadresseFirma { get; set; }
        public string CRechnungsadresseVorname { get; set; }
        public string CRechnungsadresseName { get; set; }
        public int? NAlterBestellung { get; set; }
        public string CLieferanschrift { get; set; }
        public int NHasEingangsrechnung { get; set; }
        public int NIstUeberfaellig { get; set; }
        public int? KInboundRef { get; set; }
    }
}
