﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayUsermessagequeue
    {
        public long KEbayDataUserOutputQueue { get; set; }
        public string CMessageType { get; set; }
        public string CMessage { get; set; }
        public string DErstellt { get; set; }
        public int? NDel { get; set; }
        public int? KEbayUser { get; set; }
    }
}
