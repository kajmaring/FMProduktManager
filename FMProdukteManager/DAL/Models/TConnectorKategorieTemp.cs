using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TConnectorKategorieTemp
    {
        public string CVaterEndpointId { get; set; }
        public int? KKindKategorie { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
