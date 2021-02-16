using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSteuerzone
    {
        public int KSteuerzone { get; set; }
        public int KFirma { get; set; }
        public string CName { get; set; }
        public string CLandIso { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
