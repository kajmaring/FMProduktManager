using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAusgangskanalEmail
    {
        public TAusgangskanalEmail()
        {
            TAusgangskanalEmailBenutzerSignatur = new HashSet<TAusgangskanalEmailBenutzerSignatur>();
            TEingangskanalEmail = new HashSet<TEingangskanalEmail>();
            TNachrichtEntwurf = new HashSet<TNachrichtEntwurf>();
        }

        public int KAusgangskanalEmail { get; set; }
        public byte NProtokoll { get; set; }
        public string CServeradresse { get; set; }
        public string CServerport { get; set; }
        public byte CVerschluesselung { get; set; }
        public string CBenutzername { get; set; }
        public string CName { get; set; }
        public bool NStandard { get; set; }
        public string CEmailAdresse { get; set; }
        public string CPasswort { get; set; }
        public int? KStatusAntwortGeschrieben { get; set; }

        public virtual TStatus KStatusAntwortGeschriebenNavigation { get; set; }
        public virtual ICollection<TAusgangskanalEmailBenutzerSignatur> TAusgangskanalEmailBenutzerSignatur { get; set; }
        public virtual ICollection<TEingangskanalEmail> TEingangskanalEmail { get; set; }
        public virtual ICollection<TNachrichtEntwurf> TNachrichtEntwurf { get; set; }
    }
}
