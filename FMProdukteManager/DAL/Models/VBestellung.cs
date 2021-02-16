using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VBestellung
    {
        public int KBestellung { get; set; }
        public int? KRechnung { get; set; }
        public int KBenutzer { get; set; }
        public int? KAdresse { get; set; }
        public int KText { get; set; }
        public int KKunde { get; set; }
        public string CBestellNr { get; set; }
        public string CType { get; set; }
        public string CAnmerkung { get; set; }
        public DateTime? DErstellt { get; set; }
        public byte? NZahlungsziel { get; set; }
        public int? KVersandart { get; set; }
        public decimal FVersandBruttoPreis { get; set; }
        public decimal FRabatt { get; set; }
        public int? KInetBestellung { get; set; }
        public string CVersandInfo { get; set; }
        public DateTime? DVersandt { get; set; }
        public string CIdentCode { get; set; }
        public string CBeschreibung { get; set; }
        public string CInet { get; set; }
        public DateTime? DLieferdatum { get; set; }
        public int? KBestellHinweis { get; set; }
        public string CErloeskonto { get; set; }
        public string CWaehrung { get; set; }
        public decimal FFaktor { get; set; }
        public int? KShop { get; set; }
        public int KFirma { get; set; }
        public int NPlatform { get; set; }
        public int KSprache { get; set; }
        public decimal FGutschein { get; set; }
        public DateTime? DGedruckt { get; set; }
        public DateTime? DMailVersandt { get; set; }
        public string CInetBestellNr { get; set; }
        public int? KZahlungsart { get; set; }
        public int? KLieferadresse { get; set; }
        public int? KRechnungsadresse { get; set; }
        public byte? NIgl { get; set; }
        public byte? NUstFrei { get; set; }
        public string CStatus { get; set; }
        public DateTime? DVersandMail { get; set; }
        public DateTime? DZahlungsMail { get; set; }
        public string CUserName { get; set; }
        public string CVerwendungszweck { get; set; }
        public decimal FSkonto { get; set; }
        public int? KColor { get; set; }
        public byte? NStorno { get; set; }
        public string CModulId { get; set; }
        public int? NZahlungsTyp { get; set; }
        public int? NHatUpload { get; set; }
        public decimal FZusatzGewicht { get; set; }
        public byte NKomplettAusgeliefert { get; set; }
        public DateTime? DBezahlt { get; set; }
        public int? KSplitBestellung { get; set; }
        public string CPuizahlungsdaten { get; set; }
        public int NSplitMoeglichStatus { get; set; }
        public string CLieferadresseTitel { get; set; }
        public string CLieferadresseFirma { get; set; }
        public string CLieferadresseVorname { get; set; }
        public string CLieferadresseNachname { get; set; }
        public string CLieferadresseZusatz { get; set; }
        public string CLieferadresseStrasse { get; set; }
        public string CLieferadressePlz { get; set; }
        public string CLieferadresseOrt { get; set; }
        public string CLieferadresseLand { get; set; }
        public string CLieferadresseMail { get; set; }
        public string CLieferadresseTelefon { get; set; }
        public string CLieferadresseFax { get; set; }
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
        public string CKundenNr { get; set; }
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
        public int? KKundengruppe { get; set; }
        public string CRueckhaltegrund { get; set; }
    }
}
