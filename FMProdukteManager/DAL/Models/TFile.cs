using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFile
    {
        public TFile()
        {
            TAusgangskanalEmailBenutzerSignatur = new HashSet<TAusgangskanalEmailBenutzerSignatur>();
            TNachricht = new HashSet<TNachricht>();
            TNachrichtEntwurf = new HashSet<TNachrichtEntwurf>();
            TNachrichtEntwurfAnhang = new HashSet<TNachrichtEntwurfAnhang>();
            TNachrichtenanhang = new HashSet<TNachrichtenanhang>();
            TNotiz1 = new HashSet<TNotiz1>();
            TNotizAnhang = new HashSet<TNotizAnhang>();
            TNotizEntwurf = new HashSet<TNotizEntwurf>();
            TNotizEntwurfAnhang = new HashSet<TNotizEntwurfAnhang>();
            TTelefonat = new HashSet<TTelefonat>();
            TTelefonatAnhang = new HashSet<TTelefonatAnhang>();
            TTelefonatEntwurf = new HashSet<TTelefonatEntwurf>();
            TTelefonatEntwurfAnhang = new HashSet<TTelefonatEntwurfAnhang>();
            TVordefinierteAntwort = new HashSet<TVordefinierteAntwort>();
        }

        public int KFile { get; set; }
        public byte[] BFile { get; set; }
        public int KBenutzer { get; set; }
        public DateTime DErstellDatum { get; set; }
        public string CFileHash { get; set; }
        public string CFileName { get; set; }
        public string CFileType { get; set; }
        public int NFileSizeKb { get; set; }

        public virtual ICollection<TAusgangskanalEmailBenutzerSignatur> TAusgangskanalEmailBenutzerSignatur { get; set; }
        public virtual ICollection<TNachricht> TNachricht { get; set; }
        public virtual ICollection<TNachrichtEntwurf> TNachrichtEntwurf { get; set; }
        public virtual ICollection<TNachrichtEntwurfAnhang> TNachrichtEntwurfAnhang { get; set; }
        public virtual ICollection<TNachrichtenanhang> TNachrichtenanhang { get; set; }
        public virtual ICollection<TNotiz1> TNotiz1 { get; set; }
        public virtual ICollection<TNotizAnhang> TNotizAnhang { get; set; }
        public virtual ICollection<TNotizEntwurf> TNotizEntwurf { get; set; }
        public virtual ICollection<TNotizEntwurfAnhang> TNotizEntwurfAnhang { get; set; }
        public virtual ICollection<TTelefonat> TTelefonat { get; set; }
        public virtual ICollection<TTelefonatAnhang> TTelefonatAnhang { get; set; }
        public virtual ICollection<TTelefonatEntwurf> TTelefonatEntwurf { get; set; }
        public virtual ICollection<TTelefonatEntwurfAnhang> TTelefonatEntwurfAnhang { get; set; }
        public virtual ICollection<TVordefinierteAntwort> TVordefinierteAntwort { get; set; }
    }
}
