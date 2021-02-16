﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMerchantVersandRef
    {
        public int KMerchantVersandRef { get; set; }
        public int KVersand { get; set; }
        public int KLieferschein { get; set; }
        public DateTimeOffset DCreatedAt { get; set; }
        public DateTimeOffset? DUpdatedAt { get; set; }
        public string COwnerId { get; set; }
        public string COutboundShippingNotificationId { get; set; }
        public byte[] BRowVersion { get; set; }

        public virtual TLieferschein KLieferscheinNavigation { get; set; }
        public virtual TVersand KVersandNavigation { get; set; }
    }
}
