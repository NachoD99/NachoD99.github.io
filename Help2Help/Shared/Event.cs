using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class Event : BaseModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int EventCategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MercadoPagoLink { get; set; } = string.Empty;
        public bool DeadLineNotificationSent { get; set; }
    }
}
