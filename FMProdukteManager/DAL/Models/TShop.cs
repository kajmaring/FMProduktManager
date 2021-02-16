using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShop
    {
        public int KShop { get; set; }
        public string CApikey { get; set; }
        public string CName { get; set; }
        public string CServerWeb { get; set; }
        public string CBenutzerWeb { get; set; }
        public string CPasswortWeb { get; set; }
        public byte? NHttpPut { get; set; }
        public byte? NShopAuftragsNr { get; set; }
        public byte? NGesperrt { get; set; }
        public int? KFirma { get; set; }
        public byte? NAngebot { get; set; }
        public int? KKategorie { get; set; }
        public byte NTyp { get; set; }
        public int? KAlterShop { get; set; }
        public byte[] BRowversion { get; set; }
        public int? KWarenlager { get; set; }
        public int? KWarenlagerPlatz { get; set; }
        public int? KWarenlagerRetoure { get; set; }
        public int? KWarenlagerRetourePlatz { get; set; }
        public byte? NWarenlagerPlatztyp { get; set; }
        public byte? NWarenlagerRetourePlatztyp { get; set; }
        public string CBelegDrucker { get; set; }
    }
}
