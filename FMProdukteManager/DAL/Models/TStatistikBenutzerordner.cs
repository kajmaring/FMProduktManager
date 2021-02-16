using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStatistikBenutzerordner
    {
        public int KStatistikBenutzerordner { get; set; }
        public int KStatistikBenutzerordnerVater { get; set; }
        public int KBenutzer { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
