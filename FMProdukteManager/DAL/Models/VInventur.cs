using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VInventur
    {
        public int KArtikel { get; set; }
        public decimal? FBestand { get; set; }
        public int KWarenlager { get; set; }
    }
}
