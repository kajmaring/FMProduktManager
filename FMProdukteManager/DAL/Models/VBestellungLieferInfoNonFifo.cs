using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VBestellungLieferInfoNonFifo
    {
        public int? KBestellung { get; set; }
        public int? NLieferbarEigen { get; set; }
        public int? NLieferbar { get; set; }
    }
}
