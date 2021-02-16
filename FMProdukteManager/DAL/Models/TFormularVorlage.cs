using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFormularVorlage
    {
        public int KFormularVorlage { get; set; }
        public byte NTyp { get; set; }
        public int KFormular { get; set; }
        public int KFormularLlvorlageDaten { get; set; }
        public string CName { get; set; }
        public int KFirma { get; set; }
        public int KSprache { get; set; }
        public int KKundenGruppe { get; set; }
        public int KLieferant { get; set; }
        public int KWarenlager { get; set; }
        public int KPlattform { get; set; }
        public string CMahnstufenName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
