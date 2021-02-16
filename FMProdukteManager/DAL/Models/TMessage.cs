using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMessage
    {
        public int KMessage { get; set; }
        public int KPackage { get; set; }
        public int? KMessageServer { get; set; }
        public string CCode { get; set; }
        public byte NStatus { get; set; }
        public DateTime DTimestamp { get; set; }
        public byte NSource { get; set; }
        public string CContent { get; set; }
        public string CContentShort { get; set; }

        public virtual TPackage KPackageNavigation { get; set; }
    }
}
