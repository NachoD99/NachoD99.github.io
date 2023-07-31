using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class MapResponseDTO
    {
        public decimal CoordinateX { get; set; } //Longitude
        public decimal CoordinateY { get; set; } //Latitude
        public string EventCategory { get; set; } = string.Empty;
        public string EventTitle { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int UserId { get; set; }
        public string UserPhone { get; set; } = string.Empty;
        public string MercadoPagoLink { get; set; } = string.Empty;
    }
}
