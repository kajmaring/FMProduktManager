using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayUser
    {
        public EbayUser()
        {
            EbayDataMembermessageIn = new HashSet<EbayDataMembermessageIn>();
            EbayDataMembermessageOut = new HashSet<EbayDataMembermessageOut>();
        }

        public int KEbayuser { get; set; }
        public string Login { get; set; }
        public string Passwort { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Umgebung { get; set; }
        public int? KFirma { get; set; }
        public byte? NSonderRegel { get; set; }
        public byte? NEbayPayment { get; set; }
        public byte NOutOfStockControl { get; set; }
        public DateTime? DLetzterBestellabgleich { get; set; }
        public string CEbayUsername { get; set; }
        public DateTime? DLetzerEbayAbgleich { get; set; }
        public byte NLagerbestaendeAendern { get; set; }

        public virtual ICollection<EbayDataMembermessageIn> EbayDataMembermessageIn { get; set; }
        public virtual ICollection<EbayDataMembermessageOut> EbayDataMembermessageOut { get; set; }
    }
}
