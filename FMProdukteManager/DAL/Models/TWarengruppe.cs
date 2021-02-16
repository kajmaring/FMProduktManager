using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWarengruppe
    {
        public TWarengruppe()
        {
            TAttributWarengruppe = new HashSet<TAttributWarengruppe>();
        }

        public int KWarengruppe { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TAttributWarengruppe> TAttributWarengruppe { get; set; }
    }
}
