using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShippingPrinterConfiguration
    {
        public int KShippingDruckDetaileinstellung { get; set; }
        public int NShippingServiceProviderType { get; set; }
        public string CRechnername { get; set; }
        public int KBenutzer { get; set; }
        public string CDruckerName { get; set; }
        public int NPageScaling { get; set; }
        public int NOrientation { get; set; }
        public byte KPrintDocumentType { get; set; }
        public int NExemplare { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TPrintDocumentType KPrintDocumentTypeNavigation { get; set; }
        public virtual TShippingServiceProvider NShippingServiceProviderTypeNavigation { get; set; }
    }
}
