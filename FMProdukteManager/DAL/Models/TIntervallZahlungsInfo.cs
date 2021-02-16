using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TIntervallZahlungsInfo
    {
        public int KIntervall { get; set; }
        public string CBankName { get; set; }
        public string CBlz { get; set; }
        public string CKontoNr { get; set; }
        public string CKartenNr { get; set; }
        public string CGueltigkeit { get; set; }
        public string CCvv { get; set; }
        public string CKartenTyp { get; set; }
        public string CInhaber { get; set; }
        public string CIban { get; set; }
        public string CBic { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
