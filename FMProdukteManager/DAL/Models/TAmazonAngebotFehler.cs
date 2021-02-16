using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAmazonAngebotFehler
    {
        public int KAmazonAngebotFehler { get; set; }
        public string CSku { get; set; }
        public int NPlattform { get; set; }
        public int KUser { get; set; }
        public string CFehlerCode { get; set; }
        public byte CFehlerTyp { get; set; }
        public string CFehlerText { get; set; }
        public DateTime DErstellt { get; set; }

        public virtual PfUser KUserNavigation { get; set; }
    }
}
