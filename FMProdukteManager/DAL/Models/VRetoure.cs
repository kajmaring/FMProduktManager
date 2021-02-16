using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VRetoure
    {
        public int KRmretoure { get; set; }
        public int KRmstatus { get; set; }
        public string CRetoureNr { get; set; }
        public string CAnsprechpartner { get; set; }
        public DateTime DErstellt { get; set; }
        public string CKommentarExtern { get; set; }
        public string CFfnReturnId { get; set; }
        public string CExternalNumber { get; set; }
        public string CFirma { get; set; }
        public string CAnrede { get; set; }
        public string CTitel { get; set; }
        public string CVorname { get; set; }
        public string CName { get; set; }
        public string CStrasse { get; set; }
        public string CPlz { get; set; }
        public string COrt { get; set; }
        public string CLand { get; set; }
        public string CTel { get; set; }
        public string CZusatz { get; set; }
        public string CAdressZusatz { get; set; }
        public string CPostId { get; set; }
        public string CMobil { get; set; }
        public string CMail { get; set; }
        public string CFax { get; set; }
        public string CBundesland { get; set; }
        public string CIso { get; set; }
        public byte NHerkunft { get; set; }
        public string CKommentarIntern { get; set; }
        public byte NStatusTyp { get; set; }
        public string CFfnWarehouseId { get; set; }
        public byte NFulfillment { get; set; }
        public string CLieferantId { get; set; }
    }
}
