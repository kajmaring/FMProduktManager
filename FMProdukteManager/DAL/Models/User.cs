using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class User
    {
        public int InternalId { get; set; }
        public string Name { get; set; }
        public int CompanyInternalId { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Department { get; set; }
        public string Fax { get; set; }
        public string MobilePhone { get; set; }
        public string Note { get; set; }
    }
}
