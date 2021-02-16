using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEingangskanalEmail
    {
        public TEingangskanalEmail()
        {
            TEingangskanalEmailLabel = new HashSet<TEingangskanalEmailLabel>();
            TGeleseneEmail = new HashSet<TGeleseneEmail>();
        }

        public int KEingangskanalEmail { get; set; }
        public byte NProtokoll { get; set; }
        public string CServeradresse { get; set; }
        public string CServerport { get; set; }
        public byte CVerschluesselung { get; set; }
        public string CBenutzername { get; set; }
        public int? NMaximalesEmailAlter { get; set; }
        public int? NIntervall { get; set; }
        public int? KAusgangskanalEmail { get; set; }
        public string CName { get; set; }
        public string CEmailAdresse { get; set; }
        public string CPasswort { get; set; }
        public int KStatusNeuesTicket { get; set; }
        public int? KStatusNeueAntwort { get; set; }
        public bool NGeleseneNachrichtenAbholen { get; set; }
        public byte NMailNachDemAbrufenLoeschen { get; set; }

        public virtual TAusgangskanalEmail KAusgangskanalEmailNavigation { get; set; }
        public virtual TStatus KStatusNeueAntwortNavigation { get; set; }
        public virtual TStatus KStatusNeuesTicketNavigation { get; set; }
        public virtual ICollection<TEingangskanalEmailLabel> TEingangskanalEmailLabel { get; set; }
        public virtual ICollection<TGeleseneEmail> TGeleseneEmail { get; set; }
    }
}
