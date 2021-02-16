using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTicket
    {
        public TTicket()
        {
            TAgentAngeseheneTickets = new HashSet<TAgentAngeseheneTickets>();
            TAgentLiestTicket = new HashSet<TAgentLiestTicket>();
            TNachricht = new HashSet<TNachricht>();
            TNachrichtEntwurf = new HashSet<TNachrichtEntwurf>();
            TNotiz1 = new HashSet<TNotiz1>();
            TNotizEntwurf = new HashSet<TNotizEntwurf>();
            TTelefonat = new HashSet<TTelefonat>();
            TTelefonatEntwurf = new HashSet<TTelefonatEntwurf>();
            TTicketBeobachter = new HashSet<TTicketBeobachter>();
            TTicketLabel = new HashSet<TTicketLabel>();
            TTicketRelationKBasisticketNavigation = new HashSet<TTicketRelation>();
            TTicketRelationKVerknuepftesTicketNavigation = new HashSet<TTicketRelation>();
        }

        public int KTicket { get; set; }
        public string CEindeutigeId { get; set; }
        public int NStatus { get; set; }
        public byte NPrioritaet { get; set; }
        public DateTime DErstellung { get; set; }
        public DateTime? DLoesung { get; set; }
        public DateTime? DAenderung { get; set; }
        public DateTime? DWiedervorlage { get; set; }
        public DateTime? DFaelligAm { get; set; }
        public byte[] BRowversion { get; set; }
        public int KBenutzerErsteller { get; set; }
        public int? KBenutzerBearbeiter { get; set; }
        public int? KKunde { get; set; }
        public bool NIstInPapierkorb { get; set; }
        public int? KLieferant { get; set; }
        public bool NBenutzererstellt { get; set; }

        public virtual Tkunde KKundeNavigation { get; set; }
        public virtual Tlieferant KLieferantNavigation { get; set; }
        public virtual TStatus NStatusNavigation { get; set; }
        public virtual ICollection<TAgentAngeseheneTickets> TAgentAngeseheneTickets { get; set; }
        public virtual ICollection<TAgentLiestTicket> TAgentLiestTicket { get; set; }
        public virtual ICollection<TNachricht> TNachricht { get; set; }
        public virtual ICollection<TNachrichtEntwurf> TNachrichtEntwurf { get; set; }
        public virtual ICollection<TNotiz1> TNotiz1 { get; set; }
        public virtual ICollection<TNotizEntwurf> TNotizEntwurf { get; set; }
        public virtual ICollection<TTelefonat> TTelefonat { get; set; }
        public virtual ICollection<TTelefonatEntwurf> TTelefonatEntwurf { get; set; }
        public virtual ICollection<TTicketBeobachter> TTicketBeobachter { get; set; }
        public virtual ICollection<TTicketLabel> TTicketLabel { get; set; }
        public virtual ICollection<TTicketRelation> TTicketRelationKBasisticketNavigation { get; set; }
        public virtual ICollection<TTicketRelation> TTicketRelationKVerknuepftesTicketNavigation { get; set; }
    }
}
