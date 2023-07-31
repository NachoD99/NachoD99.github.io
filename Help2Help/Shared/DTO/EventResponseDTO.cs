using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class EventResponseDTO
    {
        //[Required]
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string FatherCategory { get; set; } = string.Empty;
        [Required]
        public string MainCategory { get; set; } = string.Empty;
        //[Required]
        public string SubCategory { get; set; } = string.Empty;
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string Province { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string Street { get; set; } = string.Empty;
        [Required]
        public int StreetNumber { get; set; }
        //[Required]
        public decimal CoordinateX { get; set; }
        //[Required]
        public decimal CoordinateY { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MercadoPagoLink { get; set; } = string.Empty;
    }
}
