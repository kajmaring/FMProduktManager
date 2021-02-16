using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Voucher
    {
        public int SalesOrderPositionInternalId { get; set; }
        public string Name { get; set; }
        public int SalesOrderInternalId { get; set; }
        public int CompanyInternalId { get; set; }
    }
}
