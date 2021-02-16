using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosgastroDruckerWarengruppe
    {
        public long KDruckerWarengruppe { get; set; }
        public long KGastroDrucker { get; set; }
        public long KWarengruppe { get; set; }
    }
}
