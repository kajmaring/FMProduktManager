using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEbayAbgleichLogeintrag
    {
        public int KEbayAbgleichLogeintrag { get; set; }
        public int KEbayAbgleichLogsitzung { get; set; }
        public DateTime DZeitpunkt { get; set; }
        public byte NSchweregrad { get; set; }
        public string CMeldung { get; set; }
        public int KEbayUser { get; set; }
        public int KSiteId { get; set; }
        public int KItemId { get; set; }
        public byte NVorgang { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TEbayAbgleichLogsitzung KEbayAbgleichLogsitzungNavigation { get; set; }
    }
}
