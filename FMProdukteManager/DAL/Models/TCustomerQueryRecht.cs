﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TCustomerQueryRecht
    {
        public int KCustomerQuery { get; set; }
        public int KRechtBenutzerGruppe { get; set; }

        public virtual TCustomerQuery KCustomerQueryNavigation { get; set; }
    }
}
