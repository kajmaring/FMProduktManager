﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VProductOption
    {
        public int KProduct { get; set; }
        public string COptionName { get; set; }
        public string COptionValue { get; set; }
    }
}
