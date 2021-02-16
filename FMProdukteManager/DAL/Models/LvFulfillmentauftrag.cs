using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvFulfillmentauftrag
    {
        public int Id { get; set; }
        public DateTime? DErstelltAm { get; set; }
        public int? NStatus { get; set; }
        public DateTime? DInBearbeitungSeit { get; set; }
        public string CKommentar { get; set; }
        public string CLieferprioritaet { get; set; }
        public string CBezugsauftragsnummer { get; set; }
        public string CBezugslieferscheinnummer { get; set; }
        public string CDienstleister { get; set; }
        public int? NAmazonUser { get; set; }
        public string CFehlermeldung { get; set; }
        public string CKundenNummer { get; set; }
        public string CLieferungFirma { get; set; }
        public string CLieferungVorname { get; set; }
        public string CLieferungName { get; set; }
        public string CLieferungStrasse { get; set; }
        public string CLieferungPlz { get; set; }
        public string CLieferungOrt { get; set; }
        public string CLieferungBundesland { get; set; }
        public string CLieferungLand { get; set; }
        public string CLieferungMail { get; set; }
        public string CLieferungTelefon { get; set; }
        public string CLieferungFax { get; set; }
        public string CLieferungAdressZusatz { get; set; }
        public string CLieferungZusatz { get; set; }
        public string CLieferungAnrede { get; set; }
        public int? NFulfillmentDienstleister { get; set; }
        public string CStornoCode { get; set; }
        public string CStornoGrund { get; set; }
        public string CKundeNr { get; set; }
        public string CKundeTitel { get; set; }
        public string CKundeFirma { get; set; }
        public string CKundeVorname { get; set; }
        public string CKundeNachname { get; set; }
        public string CKundeZusatz { get; set; }
        public string CKundeStrasse { get; set; }
        public string CKundePlz { get; set; }
        public string CKundeOrt { get; set; }
        public string CKundeLand { get; set; }
        public string CKundeMail { get; set; }
        public string CKundeTelefon { get; set; }
        public string CKundeFax { get; set; }
        public string CRechnungsadresseTitel { get; set; }
        public string CRechnungsadresseFirma { get; set; }
        public string CRechnungsadresseVorname { get; set; }
        public string CRechnungsadresseNachname { get; set; }
        public string CRechnungsadresseZusatz { get; set; }
        public string CRechnungsadresseStrasse { get; set; }
        public string CRechnungsadressePlz { get; set; }
        public string CRechnungsadresseOrt { get; set; }
        public string CRechnungsadresseLand { get; set; }
        public string CRechnungsadresseMail { get; set; }
        public string CRechnungsadresseTelefon { get; set; }
        public string CRechnungsadresseFax { get; set; }
        public string CTransaktionsnummer { get; set; }
    }
}
