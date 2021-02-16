using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWorkflowEigenschaft
    {
        public int KWorkflowEigenschaft { get; set; }
        public string CDotLiquid { get; set; }
        public string CName { get; set; }
        public int NObjekt { get; set; }
        public byte NDatenTyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
