using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVaterLabelLabel
    {
        public int KVaterLabelLabel { get; set; }
        public int KVater { get; set; }
        public int KLabel { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TLabel KLabelNavigation { get; set; }
        public virtual TLabel KVaterNavigation { get; set; }
    }
}
