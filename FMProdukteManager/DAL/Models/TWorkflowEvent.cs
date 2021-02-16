using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWorkflowEvent
    {
        public int KWorkflowEvent { get; set; }
        public int NEvent { get; set; }
        public int NObjekt { get; set; }
        public string CDisplayName { get; set; }
        public string CSortierung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
