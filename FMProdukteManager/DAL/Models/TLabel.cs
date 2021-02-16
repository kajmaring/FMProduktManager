using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLabel
    {
        public TLabel()
        {
            TEingangskanalEmailLabel = new HashSet<TEingangskanalEmailLabel>();
            TLabelBenutzergruppeRechte = new HashSet<TLabelBenutzergruppeRechte>();
            TTicketLabel = new HashSet<TTicketLabel>();
            TVaterLabelLabelKLabelNavigation = new HashSet<TVaterLabelLabel>();
            TVaterLabelLabelKVaterNavigation = new HashSet<TVaterLabelLabel>();
        }

        public int KLabel { get; set; }
        public byte NTyp { get; set; }
        public string CName { get; set; }
        public string CBeschreibung { get; set; }
        public string CColor { get; set; }
        public byte? NVorgangsId { get; set; }
        public int NSort { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TEingangskanalEmailLabel> TEingangskanalEmailLabel { get; set; }
        public virtual ICollection<TLabelBenutzergruppeRechte> TLabelBenutzergruppeRechte { get; set; }
        public virtual ICollection<TTicketLabel> TTicketLabel { get; set; }
        public virtual ICollection<TVaterLabelLabel> TVaterLabelLabelKLabelNavigation { get; set; }
        public virtual ICollection<TVaterLabelLabel> TVaterLabelLabelKVaterNavigation { get; set; }
    }
}
