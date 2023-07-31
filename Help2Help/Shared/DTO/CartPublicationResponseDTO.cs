using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class CartPublicationResponseDTO
    {
        public int PublicationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int PublicationTypeId { get; set; }
        public string PublicationType { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
