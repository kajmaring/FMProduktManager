﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VProduct
    {
        public int KArtikel { get; set; }
        public string CArtNr { get; set; }
        public decimal FVknetto { get; set; }
        public decimal FUvp { get; set; }
        public string CAnmerkung { get; set; }
        public decimal NMindestbestellmaenge { get; set; }
        public string CBarcode { get; set; }
        public string CTopArtikel { get; set; }
        public decimal FGewicht { get; set; }
        public string CLagerArtikel { get; set; }
        public string CTeilbar { get; set; }
        public string CLagerAktiv { get; set; }
        public string CLagerKleinerNull { get; set; }
        public decimal NMidestbestand { get; set; }
        public string CLagerVariation { get; set; }
        public DateTime? DMod { get; set; }
        public byte? NVpe { get; set; }
        public decimal FVpewert { get; set; }
        public string CSuchbegriffe { get; set; }
        public string CTaric { get; set; }
        public string CHerkunftsland { get; set; }
        public DateTime? DErstelldatum { get; set; }
        public DateTime? DErscheinungsdatum { get; set; }
        public int? NSort { get; set; }
        public int? KVersandklasse { get; set; }
        public decimal FArtGewicht { get; set; }
        public string CHan { get; set; }
        public string CIsbn { get; set; }
        public string CUnnummer { get; set; }
        public string CGefahrnr { get; set; }
        public string CAsin { get; set; }
        public int KVaterArtikel { get; set; }
        public byte NIstVater { get; set; }
        public decimal FAbnahmeintervall { get; set; }
        public string CUpc { get; set; }
        public int KWarengruppe { get; set; }
        public string CEpid { get; set; }
        public byte NMhd { get; set; }
        public byte NCharge { get; set; }
        public int? KHersteller { get; set; }
        public int? KMassEinheit { get; set; }
        public decimal FMassMenge { get; set; }
        public int? KGrundPreisEinheit { get; set; }
        public decimal FGrundpreisMenge { get; set; }
        public decimal FBreite { get; set; }
        public decimal FHoehe { get; set; }
        public decimal FLaenge { get; set; }
        public int? KVerkaufsEinheit { get; set; }
        public DateTime? DZulaufVerfuegbarAm { get; set; }
        public decimal NZulaufVerfuegbarMenge { get; set; }
        public string CJpid { get; set; }
        public string CGrundpreisCode { get; set; }
        public string CGrundpreisDisplayCode { get; set; }
        public string CMassEinheitCode { get; set; }
        public int NAktion { get; set; }
        public string HerstellerName { get; set; }
    }
}
