using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VLieferscheinPosDetail
    {
        public int KLieferschein { get; set; }
        public int KLieferscheinPos { get; set; }
        public decimal FAnzahl { get; set; }
        public int KWarenlager { get; set; }
        public string CWarenlagerName { get; set; }
        public string CWarenlagerplatzName { get; set; }
        public string CCharge { get; set; }
        public DateTime? DMhd { get; set; }
    }
}
