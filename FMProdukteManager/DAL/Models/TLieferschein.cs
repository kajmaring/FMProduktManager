using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLieferschein
    {
        public TLieferschein()
        {
            TFulfillerLieferscheinRef = new HashSet<TFulfillerLieferscheinRef>();
            TMerchantInboundShippingNotificationRef = new HashSet<TMerchantInboundShippingNotificationRef>();
            TMerchantVersandRef = new HashSet<TMerchantVersandRef>();
        }

        public int KLieferschein { get; set; }
        public int KBestellung { get; set; }
        public int KBenutzer { get; set; }
        public string CLieferscheinNr { get; set; }
        public string CHinweis { get; set; }
        public DateTime? DMailVersand { get; set; }
        public DateTime? DErstellt { get; set; }
        public DateTime? DGedruckt { get; set; }
        public int? NFulfillment { get; set; }
        public int? KLieferantenBestellung { get; set; }
        public int? KSessionId { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TFulfillerLieferscheinRef> TFulfillerLieferscheinRef { get; set; }
        public virtual ICollection<TMerchantInboundShippingNotificationRef> TMerchantInboundShippingNotificationRef { get; set; }
        public virtual ICollection<TMerchantVersandRef> TMerchantVersandRef { get; set; }
    }
}
