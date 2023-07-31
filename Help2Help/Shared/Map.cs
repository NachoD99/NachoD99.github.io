using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class Map : BaseModel
    {
        public string Street { get; set; } = string.Empty;
        public int StreetNumber { get; set; }
        public string Locality { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        [Column(TypeName = "decimal(18,15)")]
        public decimal CoordinateX { get; set; } //Longitude
        [Column(TypeName = "decimal(18,15)")]
        public decimal CoordinateY { get; set; } //Latitude
        public int EventCategoryId { get; set; }
        public int EventId { get; set; }
    }
}
