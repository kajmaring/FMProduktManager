using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvLieferschein
    {
        public int KLieferschein { get; set; }
        public string CLieferscheinNr { get; set; }
        public DateTime? DErstellt { get; set; }
        public DateTime? DGedruckt { get; set; }
        public DateTime? DMailVersand { get; set; }
        public string CHinweis { get; set; }
        public int? KLieferantenBestellung { get; set; }
        public int? NIstFulfillment { get; set; }
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
        public string CLieferadresseTitel { get; set; }
        public string CLieferadresseFirma { get; set; }
        public string CLieferadresseVorname { get; set; }
        public string CLieferadresseNachname { get; set; }
        public string CLieferadresseZusatz { get; set; }
        public string CLieferadresseStrasse { get; set; }
        public string CLieferadressePlz { get; set; }
        public string CLieferadresseOrt { get; set; }
        public string CLieferadresseLand { get; set; }
        public string CLieferadresseBundesland { get; set; }
        public string CLieferadresseMail { get; set; }
        public string CLieferadresseTelefon { get; set; }
        public string CLieferadresseFax { get; set; }
        public string CLieferadresseAdressZusatz { get; set; }
        public string CLieferadresseAnrede { get; set; }
        public string CBestellungStatus { get; set; }
        public string CBestellungInetBestellNr { get; set; }
        public int KKunde { get; set; }
        public int NPlattform { get; set; }
        public int KFirma { get; set; }
        public string CBestellNr { get; set; }
        public int? KVersandart { get; set; }
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
        public string CFirmaName { get; set; }
        public string CRechnungsNr { get; set; }
        public string CLieferantFirma { get; set; }
        public string CFulfillmentLager { get; set; }
        public string CBenutzerName { get; set; }
        public int NIstRechnungVorhanden { get; set; }
        public int NIstDropshipping { get; set; }
        public DateTime? DVersendet { get; set; }
        public int? NAnzahlPakete { get; set; }
        public int? NAnzahlVersendetePakete { get; set; }
        public byte? NShippingStatus { get; set; }
        public decimal? FArtikelgewicht { get; set; }
        public decimal? FVersandgewicht { get; set; }
        public int? NIstWmslieferschein { get; set; }
        public string CUsername { get; set; }
        public int? NPlattformTyp { get; set; }
    }
}
