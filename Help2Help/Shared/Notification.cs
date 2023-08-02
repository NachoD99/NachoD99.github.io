using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class Notification : BaseModel
    {
        public string Message { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public int PublicationId { get; set; }
    }

    public enum NotificationTypes
    {
        Like,
        Comment,
        Event,
        Donation,
        RequestVerification,
        ApproveVerification,
        DisapproveVerification,
        EventDeadline
    }
}
