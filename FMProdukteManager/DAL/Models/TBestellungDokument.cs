using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellungDokument
    {
        public int KBestellungDokument { get; set; }
        public int KBestellung { get; set; }
        public byte[] BDokument { get; set; }
        public int NDokumentTyp { get; set; }
        public int NDateigroesse { get; set; }
        public string CDateierweiterung { get; set; }
        public DateTime DErstellt { get; set; }
        public DateTime? DAenderung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
