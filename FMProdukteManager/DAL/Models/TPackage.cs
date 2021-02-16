using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPackage
    {
        public TPackage()
        {
            TMessage = new HashSet<TMessage>();
            TState = new HashSet<TState>();
        }

        public int KPackage { get; set; }
        public int? KPackageServer { get; set; }
        public int KVersand { get; set; }
        public string CTrackingId { get; set; }
        public byte NServiceProvider { get; set; }
        public string CShipperCountryIso { get; set; }
        public string CReceiverCountryIso { get; set; }
        public string CReceiverZipCode { get; set; }
        public DateTime? DNextUpdateDate { get; set; }
        public DateTime? DRegisteredAt { get; set; }

        public virtual TVersand KVersandNavigation { get; set; }
        public virtual ICollection<TMessage> TMessage { get; set; }
        public virtual ICollection<TState> TState { get; set; }
    }
}
