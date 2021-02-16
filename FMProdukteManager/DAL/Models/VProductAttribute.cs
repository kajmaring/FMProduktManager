using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VProductAttribute
    {
        public int KProduct { get; set; }
        public string CAttributeName { get; set; }
        public decimal FPrice { get; set; }
        public int NSort { get; set; }
        public int KType { get; set; }
        public string CGroup { get; set; }
    }
}
