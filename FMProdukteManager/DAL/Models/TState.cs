using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TState
    {
        public int KState { get; set; }
        public int KPackage { get; set; }
        public int? KStateServer { get; set; }
        public byte NStateType { get; set; }
        public DateTime? DDate { get; set; }
        public string CText { get; set; }
        public string CProviderState { get; set; }
        public string CLocation { get; set; }
        public string CCountry { get; set; }

        public virtual TPackage KPackageNavigation { get; set; }
    }
}
