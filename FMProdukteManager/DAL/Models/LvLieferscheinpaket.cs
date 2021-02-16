using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvLieferscheinpaket
    {
        public int KLieferschein { get; set; }
        public int KInternePaketnummer { get; set; }
        public string CTrackingId { get; set; }
        public string CSendungsreferenz { get; set; }
        public DateTime? DVerpackt { get; set; }
        public DateTime? DVersendet { get; set; }
        public string CHinweis { get; set; }
        public string CFulfillmentCenter { get; set; }
        public DateTime? DVoraussichtlichesLieferdatum { get; set; }
        public string CVersandartName { get; set; }
        public decimal FGewicht { get; set; }
        public byte NStatus { get; set; }
        public string CEnclosedReturnIdentCode { get; set; }
    }
}
