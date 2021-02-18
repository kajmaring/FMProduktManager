using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string ArtNumber { get; set; }

        public string Name { get; set; }

        public byte[] Picture { get; set; }

    }
}
