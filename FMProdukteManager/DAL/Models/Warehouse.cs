using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Warehouse
    {
        public int InternalId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ContactSalutation { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactDepartment { get; set; }
        public string WarehouseType { get; set; }
    }
}
