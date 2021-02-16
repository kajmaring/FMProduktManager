using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachricht
    {
        public TNachricht()
        {
            TAgentAngeseheneTickets = new HashSet<TAgentAngeseheneTickets>();
            TGeleseneEmail = new HashSet<TGeleseneEmail>();
            TNachrichtAngebot = new HashSet<TNachrichtAngebot>();
            TNachrichtArtikel = new HashSet<TNachrichtArtikel>();
            TNachrichtAuftrag = new HashSet<TNachrichtAuftrag>();
            TNachrichtBenutzerOptionen = new HashSet<TNachrichtBenutzerOptionen>();
            TNachrichtEingangsrechnung = new HashSet<TNachrichtEingangsrechnung>();
            TNachrichtLieferantenbestellung = new HashSet<TNachrichtLieferantenbestellung>();
            TNachrichtPreisanfrage = new HashSet<TNachrichtPreisanfrage>();
            TNachrichtRechnung = new HashSet<TNachrichtRechnung>();
            TNachrichtRechnungskorrektur = new HashSet<TNachrichtRechnungskorrektur>();
            TNachrichtRetoure = new HashSet<TNachrichtRetoure>();
            TNachrichtTyp = new HashSet<TNachrichtTyp>();
            TNachrichtenanhang = new HashSet<TNachrichtenanhang>();
        }

        public int KNachricht { get; set; }
        public string CInhalt { get; set; }
        public DateTime DErstellung { get; set; }
        public string CBeschreibung { get; set; }
        public byte[] BRowversion { get; set; }
        public int? KAntwortkanal { get; set; }
        public int KTicket { get; set; }
        public int? KBenutzerErsteller { get; set; }
        public byte NRichtung { get; set; }
        public DateTime DEmpfangen { get; set; }
        public DateTime? DGesendet { get; set; }
        public bool NVorgangserkennungGelaufen { get; set; }
        public int KFileHtmlInhalt { get; set; }
        public string CEmpfaenger { get; set; }

        public virtual TFile KFileHtmlInhaltNavigation { get; set; }
        public virtual TTicket KTicketNavigation { get; set; }
        public virtual ICollection<TAgentAngeseheneTickets> TAgentAngeseheneTickets { get; set; }
        public virtual ICollection<TGeleseneEmail> TGeleseneEmail { get; set; }
        public virtual ICollection<TNachrichtAngebot> TNachrichtAngebot { get; set; }
        public virtual ICollection<TNachrichtArtikel> TNachrichtArtikel { get; set; }
        public virtual ICollection<TNachrichtAuftrag> TNachrichtAuftrag { get; set; }
        public virtual ICollection<TNachrichtBenutzerOptionen> TNachrichtBenutzerOptionen { get; set; }
        public virtual ICollection<TNachrichtEingangsrechnung> TNachrichtEingangsrechnung { get; set; }
        public virtual ICollection<TNachrichtLieferantenbestellung> TNachrichtLieferantenbestellung { get; set; }
        public virtual ICollection<TNachrichtPreisanfrage> TNachrichtPreisanfrage { get; set; }
        public virtual ICollection<TNachrichtRechnung> TNachrichtRechnung { get; set; }
        public virtual ICollection<TNachrichtRechnungskorrektur> TNachrichtRechnungskorrektur { get; set; }
        public virtual ICollection<TNachrichtRetoure> TNachrichtRetoure { get; set; }
        public virtual ICollection<TNachrichtTyp> TNachrichtTyp { get; set; }
        public virtual ICollection<TNachrichtenanhang> TNachrichtenanhang { get; set; }
    }
}
