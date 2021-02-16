using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEingangskanalEmailLabel
    {
        public int KEingangskanalEmailLabel { get; set; }
        public int KEingangskanalEmail { get; set; }
        public int KLabel { get; set; }

        public virtual TEingangskanalEmail KEingangskanalEmailNavigation { get; set; }
        public virtual TLabel KLabelNavigation { get; set; }
    }
}
