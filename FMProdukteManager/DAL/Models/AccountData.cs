using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AccountData
    {
        public int InternalId { get; set; }
        public int? CustomerInternalId { get; set; }
        public string Bank { get; set; }
        public string AccountHolder { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
    }
}
