using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VBestellPosLieferInfoProLagerVirtuell
    {
        public int KBestellung { get; set; }
        public int KBestellPos { get; set; }
        public int KArtikel { get; set; }
        public int? KWarenLager { get; set; }
        public decimal? FAnzahlFehlbestand { get; set; }
        public decimal? FAnzahlFehlbestandEigen { get; set; }
        public decimal? FAnzahlOffen { get; set; }
        public decimal? FAnzahlReserviert { get; set; }
        public decimal? FAnzahlReserviertEigen { get; set; }
    }
}
