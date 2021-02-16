using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPrintDocumentType
    {
        public TPrintDocumentType()
        {
            TShippingPrinterConfiguration = new HashSet<TShippingPrinterConfiguration>();
        }

        public byte KPrintDocumentType { get; set; }
        public string CDokumentName { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TShippingPrinterConfiguration> TShippingPrinterConfiguration { get; set; }
    }
}
