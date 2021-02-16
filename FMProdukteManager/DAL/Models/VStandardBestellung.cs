using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VStandardBestellung
    {
        public int KBestellung { get; set; }
        public int? KRechnung { get; set; }
        public int KBenutzer { get; set; }
        public int? KAdresse { get; set; }
        public int KText { get; set; }
        public int KKunde { get; set; }
        public int? KVersandart { get; set; }
        public int? KInetBestellung { get; set; }
        public int? KBestellhinweis { get; set; }
        public int? KShop { get; set; }
        public int KFirma { get; set; }
        public int NPlattform { get; set; }
        public int NPlattformTyp { get; set; }
        public int KSprache { get; set; }
        public int? KZahlungsart { get; set; }
        public int? KLieferadresse { get; set; }
        public int? KRechnungsadresse { get; set; }
        public int? KColor { get; set; }
        public string CAuftragsnummer { get; set; }
        public string CAnmerkung { get; set; }
        public byte? NZahlungszielInTagen { get; set; }
        public string CVersandinfo { get; set; }
        public byte NKomplettAusgeliefert { get; set; }
        public DateTime? DVoraussichtlichesLieferdatum { get; set; }
        public string CErloeskonto { get; set; }
        public string CWaehrung { get; set; }
        public decimal FWaehrungsfaktor { get; set; }
        public decimal FKundenguthaben { get; set; }
        public DateTime? DDruckdatum { get; set; }
        public DateTime? DMaildatum { get; set; }
        public DateTime? DZahlungsmaildatum { get; set; }
        public string CBeschreibung { get; set; }
        public int KRueckhalteGrund { get; set; }
        public int? NAuftragsprioritaet { get; set; }
        public string CVersandlandIso { get; set; }
        public string CVersandlandWaehrung { get; set; }
        public decimal FVersandlandWaehrungFaktor { get; set; }
        public int NInet { get; set; }
        public string CShopbestellnummer { get; set; }
        public int NInnergemeinschaftlicheLieferung { get; set; }
        public int NUmsatzsteuerfrei { get; set; }
        public string CStatustext { get; set; }
        public string CeBayBenutzername { get; set; }
        public string CeBayVerwendungszweck { get; set; }
        public byte? NStorniert { get; set; }
        public DateTime? DBezahldatum { get; set; }
        public string CZahlungsmodulId { get; set; }
        public decimal FZusatzgewicht { get; set; }
        public DateTime? DErstellt { get; set; }
        public string CType { get; set; }
        public bool NIstExterneRechnung { get; set; }
        public bool NIstReadOnly { get; set; }
        public byte? NStorno { get; set; }
        public DateTime? DVersandt { get; set; }
        public string CRechnungsadresseFirma { get; set; }
        public string CRechnungsadresseVorname { get; set; }
        public string CRechnungsadresseNachname { get; set; }
        public string CRechnungsadresseStrasse { get; set; }
        public string CRechnungsadressePlz { get; set; }
        public string CRechnungsadresseOrt { get; set; }
        public string CRechnungsadresseLand { get; set; }
        public string CRechnungsadresseTelefon { get; set; }
        public string CRechnungsadresseMobiltelefonnummer { get; set; }
        public string CRechnungsadresseFax { get; set; }
        public string CRechnungsadresseMail { get; set; }
        public string CRechnungsadresseBundesland { get; set; }
        public string CRechnungsadresseLandIso { get; set; }
        public string CRechnungsadresseKundennummer { get; set; }
        public string CRechnungsadresseZuHaenden { get; set; }
        public string CLieferadresseFirma { get; set; }
        public string CLieferadresseVorname { get; set; }
        public string CLieferadresseNachname { get; set; }
        public string CLieferadresseStrasse { get; set; }
        public string CLieferadressePlz { get; set; }
        public string CLieferadresseOrt { get; set; }
        public string CLieferadresseLand { get; set; }
        public string CLieferadresseTelefon { get; set; }
        public string CLieferadresseMobiltelefonnummer { get; set; }
        public string CLieferadresseFax { get; set; }
        public string CLieferadresseMail { get; set; }
        public string CLieferadresseBundesland { get; set; }
        public string CLieferadresseLandIso { get; set; }
        public string CLieferadresseZusatz { get; set; }
        public string CLieferadresseAdressZusatz { get; set; }
        public decimal FAuftragswertBrutto { get; set; }
        public decimal FAuftragswertNetto { get; set; }
        public decimal FGutgeschriebenerWert { get; set; }
        public decimal FBereitsgezahltWert { get; set; }
        public bool NExistiertLieferschein { get; set; }
        public byte? NRechnungZahlungsziel { get; set; }
        public string CRechnungsNummer { get; set; }
        public DateTime? DRechnungErstellt { get; set; }
        public string CZahlungsartName { get; set; }
        public decimal? FMahnGebuehr { get; set; }
        public DateTime? DZahlungsfrist { get; set; }
        public int? NMahnstufe { get; set; }
        public string CRueckhaltegrundName { get; set; }
        public string CShopName { get; set; }
        public string CFirmaName { get; set; }
        public string CVersandartName { get; set; }
        public string CIstBezahlt { get; set; }
    }
}
