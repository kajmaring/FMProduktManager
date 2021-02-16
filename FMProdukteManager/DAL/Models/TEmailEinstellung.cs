using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEmailEinstellung
    {
        public int KEmailEinstellungen { get; set; }
        public int KFirma { get; set; }
        public string CServerSmtp { get; set; }
        public int NPortSmtp { get; set; }
        public string CNutzernameSmtp { get; set; }
        public string CPasswortSmtp { get; set; }
        public string CAbsender { get; set; }
        public string CBcc { get; set; }
        public int NSecurity { get; set; }
        public byte NSigPortalAktiv { get; set; }
        public string CSigPortalKdNummer { get; set; }
        public string CSigPortalNutzername { get; set; }
        public string CSigPortalPasswort { get; set; }
        public byte NSigPortalVerifizierung { get; set; }
        public string CSigPortalPfad { get; set; }
        public byte NSigBefehlAktiv { get; set; }
        public string CSigBefehlDateiname { get; set; }
        public string CSigBefehlParameter { get; set; }
        public byte NSmimeaktiv { get; set; }
        public string CSmimepasswort { get; set; }
        public byte[] BSmimezertifikatData { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
