﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLieferantenBestellungLa
    {
        public int KLieferantenBestellungLa { get; set; }
        public string CKundennummer { get; set; }
        public string CFirma { get; set; }
        public string CFirmenZusatz { get; set; }
        public string CAnrede { get; set; }
        public string CTitel { get; set; }
        public string CVorname { get; set; }
        public string CNachname { get; set; }
        public string CStrasse { get; set; }
        public string CAdresszusatz { get; set; }
        public string CPlz { get; set; }
        public string COrt { get; set; }
        public string CBundesland { get; set; }
        public string CLandIso { get; set; }
        public string CTel { get; set; }
        public string CFax { get; set; }
        public string CMobil { get; set; }
        public string CMail { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
