using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWorkflowAktion
    {
        public int KWorkflowAktion { get; set; }
        public int KWorkflow { get; set; }
        public string XXmlObjekt { get; set; }
        public int NPos { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
