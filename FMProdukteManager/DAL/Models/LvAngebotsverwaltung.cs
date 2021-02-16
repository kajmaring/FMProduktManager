using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvAngebotsverwaltung
    {
        public int KBestellung { get; set; }
        public int KBenutzer { get; set; }
        public int? KAdresse { get; set; }
        public int KText { get; set; }
        public int KKunde { get; set; }
        public int? KVersandart { get; set; }
        public int? KInetBestellung { get; set; }
        public int? KBestellhinweis { get; set; }
        public int KFirma { get; set; }
        public int KSprache { get; set; }
        public int? KShop { get; set; }
        public int? KZahlungsart { get; set; }
        public int? KLieferadresse { get; set; }
        public int? KRechnungsadresse { get; set; }
        public int? KColor { get; set; }
        public string CAngebotsnummer { get; set; }
        public int NPlattform { get; set; }
        public string CAnmerkung { get; set; }
        public string CErloeskonto { get; set; }
        public string CWaehrung { get; set; }
        public decimal FWaehrungsfaktor { get; set; }
        public decimal FKundenguthaben { get; set; }
        public DateTime? DDruckdatum { get; set; }
        public DateTime? DMaildatum { get; set; }
        public DateTime? DZahlungsmaildatum { get; set; }
        public string CBeschreibung { get; set; }
        public byte? NInnergemeinschaftlicheLieferung { get; set; }
        public byte? NUmsatzsteuerfrei { get; set; }
        public string CStatustext { get; set; }
        public DateTime? DBezahldatum { get; set; }
        public decimal FZusatzgewicht { get; set; }
        public DateTime? DErstellt { get; set; }
        public string CRechnungsadresseFirma { get; set; }
        public string CRechnungsadresseAnrede { get; set; }
        public string CRechnungsadresseTitel { get; set; }
        public string CRechnungsadresseVorname { get; set; }
        public string CRechnungsadresseNachname { get; set; }
        public string CRechnungsadresseStrasse { get; set; }
        public string CRechnungsadresseAdresszusatz { get; set; }
        public string CRechnungsadressePlz { get; set; }
        public string CRechnungsadresseOrt { get; set; }
        public string CRechnungsadresseLand { get; set; }
        public string CRechnungsadresseTelefon { get; set; }
        public string CRechnungsadresseMobilTelefon { get; set; }
        public string CRechnungsadresseFax { get; set; }
        public string CRechnungsadresseMail { get; set; }
        public string CRechnungsadresseZusatz { get; set; }
        public string CRechnungsadressePostId { get; set; }
        public string CRechnungsadresseBundesland { get; set; }
        public string CRechnungsadresseLandIso { get; set; }
        public string CRechnungsadresseKundennummer { get; set; }
        public string CRechnungsadresseZuHaenden { get; set; }
        public string CLieferadresseFirma { get; set; }
        public string CLieferadresseAnrede { get; set; }
        public string CLieferadresseTitel { get; set; }
        public string CLieferadresseVorname { get; set; }
        public string CLieferadresseNachname { get; set; }
        public string CLieferadresseStrasse { get; set; }
        public string CLieferadresseAdresszusatz { get; set; }
        public string CLieferadressePlz { get; set; }
        public string CLieferadresseOrt { get; set; }
        public string CLieferadresseLand { get; set; }
        public string CLieferadresseTelefon { get; set; }
        public string CLieferadresseMobilTelefon { get; set; }
        public string CLieferadresseFax { get; set; }
        public string CLieferadresseMail { get; set; }
        public string CLieferadresseZusatz { get; set; }
        public string CLieferadressePostId { get; set; }
        public string CLieferadresseBundesland { get; set; }
        public string CLieferadresseLandIso { get; set; }
        public string CBenutzername { get; set; }
        public string CFirmenname { get; set; }
        public string CShopname { get; set; }
        public string CKundengruppe { get; set; }
        public string CZahlungsartname { get; set; }
        public string CVersandartname { get; set; }
        public string CKundeNr { get; set; }
        public string CKundeTitel { get; set; }
        public string CKundeFirma { get; set; }
        public string CKundeVorname { get; set; }
        public string CKundeNachname { get; set; }
        public string CKundeZusatz { get; set; }
        public string CKundeStrasse { get; set; }
        public string CKundePlz { get; set; }
        public string CKundeOrt { get; set; }
        public string CKundeBundesland { get; set; }
        public string CKundeLand { get; set; }
        public string CKundeMail { get; set; }
        public string CKundeTelefon { get; set; }
        public string CKundeFax { get; set; }
        public string CKunde { get; set; }
        public decimal? FAngebotswert { get; set; }
        public string CSonstiges { get; set; }
        public string CShopbestellnummer { get; set; }
    }
}
