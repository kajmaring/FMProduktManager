using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Currency
    {
        public int InternalId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyNameHtml { get; set; }
        public decimal Factor { get; set; }
        public string CurrencyIso { get; set; }
        public bool? Default { get; set; }
    }
}
