using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvPickliste
    {
        public int KPickliste { get; set; }
        public int? KWarenLager { get; set; }
        public string CWarenlagerName { get; set; }
        public int? NStatus { get; set; }
        public byte NLagerplatzVerwaltung { get; set; }
        public string CAnlagebenutzer { get; set; }
        public DateTime? DZeitstempel { get; set; }
        public DateTime? DGedruckt { get; set; }
        public string CLetzterBenutzer { get; set; }
        public DateTime? DLetzteBearbeitung { get; set; }
        public string CVorlage { get; set; }
    }
}
