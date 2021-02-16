using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonGroup
    {
        public int KGroup { get; set; }
        public string CName { get; set; }
        public int KPlattform { get; set; }
        public byte? NAktiv { get; set; }
    }
}
