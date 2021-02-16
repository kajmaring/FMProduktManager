using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDeIs
    {
        public int? CategoryId { get; set; }
        public int? KName { get; set; }
        public string CHelpText { get; set; }
        public string CHelpUrl { get; set; }
        public byte? NSelectionMode { get; set; }
        public byte? NMaxValues { get; set; }
        public byte? NMinValues { get; set; }
        public byte? NSort { get; set; }
    }
}
