using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAbverkauf
    {
        public TAbverkauf()
        {
            TVorlage1 = new HashSet<TVorlage1>();
        }

        public int KAbverkauf { get; set; }
        public byte NAktiv { get; set; }
        public int NBestandBis { get; set; }
        public decimal FAenderungMinPreis { get; set; }
        public decimal FAenderungMaxPreis { get; set; }
        public byte NAenderungMinPreisTyp { get; set; }
        public byte NAenderungMaxPreisTyp { get; set; }

        public virtual ICollection<TVorlage1> TVorlage1 { get; set; }
    }
}
