using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFormularLlvorlageDaten
    {
        public int KFormularLlvorlageDaten { get; set; }
        public DateTime DAktualisiert { get; set; }
        public byte[] BDaten { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
