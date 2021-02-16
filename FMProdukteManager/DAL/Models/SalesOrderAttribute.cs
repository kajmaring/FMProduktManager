using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SalesOrderAttribute
    {
        public int InternalId { get; set; }
        public int? SalesOrderInternalId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
    }
}
