using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibraries.DTO
{
    public class ArtikelDTO
    {
        public string ArtikelNummer { get; set; }

        public string ArtikelName { get; set; }
        
        public byte[] Bild { get; set; }
    }
}
