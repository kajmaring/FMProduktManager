using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShippingServiceProvider
    {
        public TShippingServiceProvider()
        {
            TShippingPrinterConfiguration = new HashSet<TShippingPrinterConfiguration>();
        }

        public int KShippingServiceProvider { get; set; }
        public byte NShippingServiceProviderType { get; set; }
        public byte NTrackingServiceProviderType { get; set; }
        public byte NOrderNo { get; set; }
        public byte NBeta { get; set; }
        public byte NVisible { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TShippingPrinterConfiguration> TShippingPrinterConfiguration { get; set; }
    }
}
