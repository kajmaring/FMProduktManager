using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMargensteigerung
    {
        public TMargensteigerung()
        {
            TVorlage1 = new HashSet<TVorlage1>();
        }

        public int KMargensteigerung { get; set; }
        public byte NAktiv { get; set; }
        public int NBestandAb { get; set; }
        public decimal FAenderungMinPreis { get; set; }
        public decimal FAenderungMaxPreis { get; set; }
        public byte NAenderungMinPreisTyp { get; set; }
        public byte NAenderungMaxPreisTyp { get; set; }

        public virtual ICollection<TVorlage1> TVorlage1 { get; set; }
    }
}
