using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVertrauenswuerdigerAbsender
    {
        public int KVertrauenswuerdigerAbsender { get; set; }
        public string CAbsender { get; set; }
        public byte NAbsenderTyp { get; set; }
        public int KBenutzerErsteller { get; set; }
        public DateTime DErstelldatum { get; set; }
    }
}
