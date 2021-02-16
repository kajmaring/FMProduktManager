using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VOrderPayment
    {
        public int? KOrder { get; set; }
        public int KPayment { get; set; }
        public string CPaymentMethodName { get; set; }
        public decimal FAmount { get; set; }
    }
}
