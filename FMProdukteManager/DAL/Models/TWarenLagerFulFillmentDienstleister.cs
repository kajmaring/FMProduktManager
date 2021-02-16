using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWarenLagerFulFillmentDienstleister
    {
        public int KWarenLager { get; set; }
        public int? KFulfillmentDienstleister { get; set; }
        public byte? NDruckLieferschein { get; set; }
        public byte? NFaxLieferschein { get; set; }
        public byte? NMailLieferschein { get; set; }
        public byte? NDruckFf { get; set; }
        public byte? NFaxFf { get; set; }
        public byte? NMailFf { get; set; }
        public int? KFormularLieferschein { get; set; }
        public int? KFormularFulfillmentAuftrag { get; set; }
        public int? KFormularFfnLieferschein { get; set; }
        public int? KFormularFfnRechnung { get; set; }
        public string XFfnOptionen { get; set; }
        public byte[] BRowversion { get; set; }
        public byte? NExportFf { get; set; }
    }
}
