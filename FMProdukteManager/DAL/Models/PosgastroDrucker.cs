using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosgastroDrucker
    {
        public long KGastroDrucker { get; set; }
        public int KKasse { get; set; }
        public string CName { get; set; }
        public string CBeschreibung { get; set; }
        public int? NArtikelSortierung { get; set; }
        public int? NArtikelVerteilung { get; set; }
        public int? NAudioSignal { get; set; }
        public int? NDruckAnzahl { get; set; }
        public int? NGleicheArtikelzusammenfassen { get; set; }
        public int? NPapiervorlauf { get; set; }
    }
}
