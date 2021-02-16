using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWorkflowBedingung
    {
        public int KWorkflowBedingung { get; set; }
        public int KWorkflow { get; set; }
        public string CEigenschaft { get; set; }
        public int NOperator { get; set; }
        public string CVergleichswert { get; set; }
        public int KWorkflowEigenschaft { get; set; }
        public byte[] BRowversion { get; set; }
        public int NPos { get; set; }
    }
}
