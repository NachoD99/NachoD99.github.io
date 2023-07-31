using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AuthenticationType { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public bool IsAuthenticated { get; set; }
        public bool TermsAndConditionsAccepted { get; set; }
        public int UserPortraitId { get; set; }
        public int ProfilePictureId { get; set; }
        public string Location { get; set; } = string.Empty;
        public string WebPageLink { get; set; } = string.Empty;
        public string InstagramLink { get; set; } = string.Empty;
        public string FacebookLink { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int StreetNumber { get; set; }
        public string Locality { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        public bool IsUserFromDonar { get; set; }
        public bool AllowDonarEvents { get; set; }
        public string Role { get; set; } = string.Empty;
        public bool VerificationInProgress { get; set; } = false;
        public bool IsONGVerified { get; set; } = false;
        public bool NotShowGuide { get; set; } = false;
    }
}
