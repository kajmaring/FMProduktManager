﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VFulfillerPendingLieferscheine
    {
        public string COutboundId { get; set; }
        public int KBestellung { get; set; }
        public int KKunde { get; set; }
        public int KLieferschein { get; set; }
        public string CFulfillerShippingNotificationNumber { get; set; }
        public string CNote { get; set; }
    }
}
