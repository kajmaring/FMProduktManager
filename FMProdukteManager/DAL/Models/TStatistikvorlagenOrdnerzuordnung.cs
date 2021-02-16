using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStatistikvorlagenOrdnerzuordnung
    {
        public int KStatistikBenutzerordner { get; set; }
        public int KStatistikvorlagenserialisierung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
