using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAmazonCompetitorAsinStrategy
    {
        public TAmazonCompetitorAsinStrategy()
        {
            TAmazonCompetitor = new HashSet<TAmazonCompetitor>();
            TAmazonTask = new HashSet<TAmazonTask>();
            TVorlage1 = new HashSet<TVorlage1>();
        }

        public int KAmazonCompetitorAsinStrategy { get; set; }
        public decimal FMinPreis { get; set; }
        public decimal FMaxPreis { get; set; }
        public decimal FPreisabstand { get; set; }
        public byte NAufschlagProzentNutzen { get; set; }
        public decimal FMinPreisAufschlagProzent { get; set; }
        public decimal FMaxPreisAufschlagProzent { get; set; }
        public byte? NFulfillment { get; set; }
        public byte? NRatingCount { get; set; }
        public byte? NRating { get; set; }
        public int NDeliveryTimeMin { get; set; }
        public int NDeliveryTimeMax { get; set; }

        public virtual ICollection<TAmazonCompetitor> TAmazonCompetitor { get; set; }
        public virtual ICollection<TAmazonTask> TAmazonTask { get; set; }
        public virtual ICollection<TVorlage1> TVorlage1 { get; set; }
    }
}
