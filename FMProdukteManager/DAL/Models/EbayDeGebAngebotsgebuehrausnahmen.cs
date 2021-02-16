using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDeGebAngebotsgebuehrausnahmen
    {
        public int KEbayDeGebAngebotsgebuehrAusnahmen { get; set; }
        public int? CategoryId { get; set; }
        public byte? NurFestpreis { get; set; }
        public decimal Gebuehr { get; set; }
    }
}
