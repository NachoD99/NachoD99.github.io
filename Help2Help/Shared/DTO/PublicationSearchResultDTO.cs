using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class PublicationSearchResultDTO
    {
        public List<Publication> Publications { get; set; } = new List<Publication>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }

    }
}
