using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VFbabestand
    {
        public int KUser { get; set; }
        public int KArtikel { get; set; }
        public int? NBestand { get; set; }
        public decimal? NBestandReserviert { get; set; }
    }
}
