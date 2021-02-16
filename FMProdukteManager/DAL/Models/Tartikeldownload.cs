using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tartikeldownload
    {
        public int KArtikel { get; set; }
        public int KDownload { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
