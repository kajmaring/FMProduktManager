using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VArtikelliste
    {
        public int KArtikel { get; set; }
        public int KStueckliste { get; set; }
        public int KVaterArtikel { get; set; }
        public int KArtikelForKategorieArtikel { get; set; }
        public string Artikelnummer { get; set; }
        public int Sortiernummer { get; set; }
        public string Artikelname { get; set; }
        public string Einheit { get; set; }
        public string Ean { get; set; }
        public string Herkunftsland { get; set; }
        public string Unnummer { get; set; }
        public string CHan { get; set; }
        public string Gefahrennummer { get; set; }
        public string Isbn { get; set; }
        public string Asin { get; set; }
        public string TaricCode { get; set; }
        public string Upc { get; set; }
        public string Hersteller { get; set; }
        public string Lieferstatus { get; set; }
        public decimal Breite { get; set; }
        public decimal Hoehe { get; set; }
        public decimal Laenge { get; set; }
        public DateTime? Erstelldatum { get; set; }
        public DateTime? Bearbeitungsdatum { get; set; }
        public string Bearbeiter { get; set; }
        public decimal EinkaufspreisDurchschnittNetto { get; set; }
        public decimal EinkaufspreisLetzerEinkauf { get; set; }
        public DateTime? DatumLetzerEinkauf { get; set; }
        public decimal VerkaufspreisNetto { get; set; }
        public decimal Uvp { get; set; }
        public decimal? Gewinn { get; set; }
        public int Zustand { get; set; }
        public string ZustandName { get; set; }
        public decimal? GewinnInProzent { get; set; }
        public decimal PreisAmazon { get; set; }
        public decimal PreisEbay { get; set; }
        public int Sonderpreis { get; set; }
        public decimal? GrundpreisWert { get; set; }
        public string Grundpreiseinheit { get; set; }
        public string Masseinheit { get; set; }
        public decimal Versandgewicht { get; set; }
        public decimal Gewicht { get; set; }
        public decimal BestandGesamt { get; set; }
        public decimal BestandEigen { get; set; }
        public decimal BestandImZulauf { get; set; }
        public decimal BestandAufEinkaufsliste { get; set; }
        public decimal BestandInAuftraegen { get; set; }
        public decimal BestandVerfuegbar { get; set; }
        public int Bestandspuffer { get; set; }
        public decimal MindestAbnahmemenge { get; set; }
        public decimal Abnahmeintervall { get; set; }
        public int BestandInAmazonAngeboten { get; set; }
        public decimal? Mindestbestand { get; set; }
        public bool? IstLagerfuehrungaktiv { get; set; }
        public bool? IstAufPreisliste { get; set; }
        public bool? IstAktiv { get; set; }
        public bool? IstTopArtikel { get; set; }
        public bool? IstNeu { get; set; }
        public bool? IstStueckliste { get; set; }
        public bool? IstStuecklistenkomponente { get; set; }
        public bool? IstSeriennummer { get; set; }
        public bool? IstStueckzahlteilbar { get; set; }
        public bool? IstUeberverkaufMoeglich { get; set; }
        public bool? IstBestandInVariationen { get; set; }
        public bool? IstVarkombiVater { get; set; }
        public bool? IstVarkombikind { get; set; }
        public bool? HatMindestbestand { get; set; }
        public bool? IstMhd { get; set; }
        public bool? IstCharge { get; set; }
        public bool? IstFuerBestellvorschlagGesperrt { get; set; }
        public bool? ShopAktiv { get; set; }
        public bool? Vpe { get; set; }
        public decimal? EbayBestand { get; set; }
        public decimal VerkaufspreisBrutto { get; set; }
        public string Anmerkung { get; set; }
        public string Lieferant { get; set; }
        public bool? BeschaffungszeitAutomatisch { get; set; }
        public int? BeschaffungszeitManuell { get; set; }
        public string Beschreibung { get; set; }
        public DateTime? ErscheintAm { get; set; }
        public string Kurzbeschreibung { get; set; }
        public bool? KeinBestellvorgang { get; set; }
        public string Serie { get; set; }
        public string Steuerklasse { get; set; }
        public string Warengruppe { get; set; }
        public int? ZusaetzlicheBearbeitungszeit { get; set; }
        public string Versandklasse { get; set; }
        public string Jtlfpid { get; set; }
        public bool? FfnAktiv { get; set; }
        public bool? FfnEigen { get; set; }
        public int ZustandSprache { get; set; }
        public decimal ReserviertGesamt { get; set; }
        public string AmazonFnsku { get; set; }
        public int Puffer { get; set; }
        public bool? SeriennummernVerfolgung { get; set; }
        public string MetaDescription { get; set; }
        public string TitleTag { get; set; }
        public string MetaKeywords { get; set; }
        public bool? LagerbestandInVariationen { get; set; }
        public int KSprache { get; set; }
    }
}
