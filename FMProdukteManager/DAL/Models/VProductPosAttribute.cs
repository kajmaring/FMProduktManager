using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VProductPosAttribute
    {
        public int KProduct { get; set; }
        public string CName { get; set; }
        public string CValue { get; set; }
        public decimal? FValueDecimal { get; set; }
    }
}
