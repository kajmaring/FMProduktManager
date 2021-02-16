using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAmazonBuyBoxStrategy
    {
        public TAmazonBuyBoxStrategy()
        {
            TAmazonTask = new HashSet<TAmazonTask>();
            TVorlage1 = new HashSet<TVorlage1>();
        }

        public int KAmazonBuyBoxStrategy { get; set; }
        public decimal FMinPreis { get; set; }
        public decimal FMaxPreis { get; set; }
        public decimal? FPreisabstand { get; set; }
        public byte NPreisabstandNutzen { get; set; }
        public byte NAufschlagProzentNutzen { get; set; }
        public decimal FMinPreisAufschlagProzent { get; set; }
        public decimal FMaxPreisAufschlagProzent { get; set; }

        public virtual ICollection<TAmazonTask> TAmazonTask { get; set; }
        public virtual ICollection<TVorlage1> TVorlage1 { get; set; }
    }
}
