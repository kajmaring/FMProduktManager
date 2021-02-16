using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAmazonCompetitor
    {
        public int KAmazonCompetitor { get; set; }
        public int KAmazonCompetitorAsinStrategy { get; set; }
        public string CAsin { get; set; }
        public decimal? NMinPreisAfn { get; set; }
        public decimal? NMinPreisMfn { get; set; }
        public DateTime? DLetztePreisAktualisierung { get; set; }
        public string CLieferzeitAfn { get; set; }
        public int? NAnzahlBewertungenAfn { get; set; }
        public string CBewertungAfn { get; set; }
        public string CLieferzeitMfn { get; set; }
        public int? NAnzahlBewertungenMfn { get; set; }
        public string CBewertungMfn { get; set; }

        public virtual TAmazonCompetitorAsinStrategy KAmazonCompetitorAsinStrategyNavigation { get; set; }
    }
}
