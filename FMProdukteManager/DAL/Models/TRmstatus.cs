﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRmstatus
    {
        public int KRmstatus { get; set; }
        public int KRmstatusParent { get; set; }
        public int NPos { get; set; }
        public byte NAktiv { get; set; }
        public byte NStatusTyp { get; set; }
        public byte NVisibleMode { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
