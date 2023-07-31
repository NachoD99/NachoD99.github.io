using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class User : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AuthenticationType { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool TermsAndConditionsAccepted { get; set; }
        public int UserPortraitId { get; set; }
        public int ProfilePictureId { get; set; }
        public string Location { get; set; } = string.Empty;
        public string WebPageLink { get; set; } = string.Empty;
        public string InstagramLink { get; set; } = string.Empty;
        public string FacebookLink { get; set; } = string.Empty;
        public int MapId { get; set; }
        public List<Notification> Notifications { get; set; } = new List<Notification>();
        public bool IsUserFromDonar { get; set; }
        public bool AllowDonarEvents { get; set; }
        public string Role { get; set; } = UserRoles.User.ToString();
        public bool VerificationInProgress { get; set; } = false;
        public bool IsONGVerified { get; set; } = false;
        public bool NotShowGuide { get; set; } = false;
    }

    public enum UserRoles
    {
        User,
        Admin
    }
}
