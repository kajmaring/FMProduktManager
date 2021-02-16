using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellung
    {
        public TBestellung()
        {
            TOutboundRef = new HashSet<TOutboundRef>();
        }

        public int KBestellung { get; set; }
        public int? TRechnungKRechnung { get; set; }
        public int TBenutzerKBenutzer { get; set; }
        public int? TAdresseKAdresse { get; set; }
        public int TTextKText { get; set; }
        public int TKundeKKunde { get; set; }
        public string CBestellNr { get; set; }
        public string CType { get; set; }
        public string CAnmerkung { get; set; }
        public DateTime? DErstellt { get; set; }
        public byte? NZahlungsziel { get; set; }
        public int? TVersandArtKVersandArt { get; set; }
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
        public int? KLogistik { get; set; }
        public int NPlatform { get; set; }
        public int KSprache { get; set; }
        public decimal FGutschein { get; set; }
        public DateTime? DGedruckt { get; set; }
        public DateTime? DMailVersandt { get; set; }
        public string CInetBestellNr { get; set; }
        public int? KZahlungsArt { get; set; }
        public int? KLieferAdresse { get; set; }
        public int? KRechnungsAdresse { get; set; }
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
        public int? NPrio { get; set; }
        public string CVersandlandIso { get; set; }
        public string CUstId { get; set; }
        public byte NPremium { get; set; }
        public string CVersandlandWaehrung { get; set; }
        public decimal FVersandlandWaehrungFaktor { get; set; }
        public int KRueckhalteGrund { get; set; }
        public string COutboundId { get; set; }
        public int? KFulfillmentLieferant { get; set; }
        public string CKundenauftragsnummer { get; set; }
        public bool NIstReadOnly { get; set; }
        public string CAmazonServiceLevel { get; set; }
        public bool NIstExterneRechnung { get; set; }
        public string CKampagne { get; set; }
        public string CKampagneParam { get; set; }
        public string CKampagneName { get; set; }
        public string CUserAgent { get; set; }
        public string CReferrer { get; set; }
        public int? NMaxLiefertage { get; set; }
        public byte[] BRowversion { get; set; }
        public DateTime? DErstelltWawi { get; set; }

        public virtual ICollection<TOutboundRef> TOutboundRef { get; set; }
    }
}
