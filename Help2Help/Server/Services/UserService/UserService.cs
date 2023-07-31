using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Help2Help.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext context;
        private readonly IConfiguration configuration;
        private readonly INotificationService notificationService;

        public UserService(DataContext context,
            IConfiguration configuration, INotificationService notificationService)
        {
            this.context = context;
            this.configuration = configuration;
            this.notificationService = notificationService;
        }

       

        public async Task<bool> UserExists(string email)
        {
            if (await this.context.Users.AnyAsync(user => user.Email.ToLower()
                 .Equals(email.ToLower())))
            {
                return true;
            }
            return false;
        }

        public async Task<ServiceResponse<UserResponseDTO>> GetCurrentUserInfo(string email)
        {
            var user = await this.context.Users.FirstOrDefaultAsync(user => user.Email.ToLower().Equals(email.ToLower()));

            if (user == null)
            {
                return new ServiceResponse<UserResponseDTO> { Success = false };
            }
            else
            {
                var userDTO = new UserResponseDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Phone = user.Phone,
                    Description = user.Description,
                    ProfilePicture = user.ProfilePicture,
                    UserPortraitId = user.UserPortraitId,
                    ProfilePictureId = user.ProfilePictureId,
                    Location = user.Location,
                    WebPageLink = user.WebPageLink,
                    InstagramLink = user.InstagramLink,
                    FacebookLink = user.InstagramLink,
                    IsUserFromDonar = user.IsUserFromDonar,
                    AllowDonarEvents = user.AllowDonarEvents,
                    Role = user.Role,
                    IsONGVerified = user.IsONGVerified,
                    VerificationInProgress = user.VerificationInProgress,
                    NotShowGuide = user.NotShowGuide
                };

                if (user.MapId != 0)
                {
                    var location = await this.context.Maps.FirstOrDefaultAsync(x => x.Id.Equals(user.MapId));

                    if (location != null)
                    {
                        userDTO.Street = location.Street;
                        userDTO.StreetNumber = location.StreetNumber;
                        userDTO.Locality = location.Locality;
                        userDTO.Province = location.Province;
                        userDTO.Country = location.Country;
                        userDTO.ZipCode = location.ZipCode;
                    }
                }
                return new ServiceResponse<UserResponseDTO> { Data = userDTO, Success = true };
            }
        }

        public async Task<ServiceResponse<UserResponseDTO>> GetUserInfo(int userId)
        {
            var user = await this.context.Users.FirstOrDefaultAsync(user => user.Id == userId);

            if (user == null)
            {
                return new ServiceResponse<UserResponseDTO> { Success = false, Message = "Usuario no encontrado" };
            }
            else
            {
                var userDTO = new UserResponseDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Phone = user.Phone,
                    Description = user.Description,
                    ProfilePicture = user.ProfilePicture,
                    UserPortraitId = user.UserPortraitId,
                    ProfilePictureId = user.ProfilePictureId,
                    Location = user.Location,
                    WebPageLink = user.WebPageLink,
                    InstagramLink = user.InstagramLink,
                    FacebookLink = user.FacebookLink,
                    IsUserFromDonar = user.IsUserFromDonar,
                    AllowDonarEvents = user.AllowDonarEvents,
                    Role = user.Role,
                    IsONGVerified = user.IsONGVerified,
                    VerificationInProgress = user.VerificationInProgress
                };

                if (user.MapId != 0)
                {
                    var location = await this.context.Maps.FirstOrDefaultAsync(x => x.Id.Equals(user.MapId));

                    if (location != null)
                    {
                        userDTO.Street = location.Street;
                        userDTO.StreetNumber = location.StreetNumber;
                        userDTO.Locality = location.Locality;
                        userDTO.Province = location.Province;
                        userDTO.Country = location.Country;
                        userDTO.ZipCode = location.ZipCode;
                    }
                }
                return new ServiceResponse<UserResponseDTO> { Data = userDTO, Success = true };
            }
        }

        public async Task<ServiceResponse<string>> EditUserInfo(UserResponseDTO user)
        {
            if ((await UserExists(user.Email)))
            {
                var usr = this.context.Users.Where(x => x.Email == user.Email).FirstOrDefaultAsync().Result;

                if (usr != null)
                {
                    usr.FirstName = user.FirstName;
                    usr.LastName = user.LastName;
                    usr.Email = user.Email;
                    usr.Phone = user.Phone;
                    usr.Description = user.Description;
                    usr.FacebookLink = user.FacebookLink;
                    usr.InstagramLink = user.InstagramLink;
                    usr.WebPageLink = user.WebPageLink;
                    usr.UpdatedDate = DateTime.Now;

                    if (user.UserPortraitId != 0) usr.UserPortraitId = user.UserPortraitId;

                    if (usr.MapId == 0)
                    {
                        var map = new Map()
                        {
                            Street = user.Street,
                            StreetNumber = user.StreetNumber,
                            Locality = user.Locality,
                            Province = user.Province,
                            ZipCode = user.ZipCode,
                            Country = "Argentina"
                        };

                        this.context.Maps.Add(map);
                        await this.context.SaveChangesAsync();

                        usr.MapId = map.Id;
                        this.context.Users.Update(usr);
                        await this.context.SaveChangesAsync();
                    }
                    else
                    {
                        var map = this.context.Maps.Where(x => x.Id.Equals(usr.MapId)).FirstOrDefaultAsync().Result;

                        if (map != null)
                        {
                            map.Street = user.Street;
                            map.StreetNumber = user.StreetNumber;
                            map.Locality = user.Locality;
                            map.Province = user.Province;
                            map.Country = "Argentina";
                            map.ZipCode = user.ZipCode;
                            map.UpdatedDate = DateTime.Now;

                            this.context.Maps.Update(map);
                            await this.context.SaveChangesAsync();
                        }
                    }

                    this.context.Users.Update(usr);
                    await this.context.SaveChangesAsync();

                    return new ServiceResponse<string> { Data = "Cambios efectuados correctamente" };
                }
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
            else
            {
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
        }

        public async Task<ServiceResponse<string>> EditProfilePhoto(Shared.Image request, User user)
        {
            if (request != null && user != null)
            {

                user.ProfilePicture = request.FileContent;

                request.OnServer = true;
                request.CreatedDate = DateTime.Now;

                this.context.Images.Add(request);
                await this.context.SaveChangesAsync();

                user.ProfilePictureId = request.Id;
                this.context.Users.Update(user);
                await this.context.SaveChangesAsync();

                return new ServiceResponse<string> { Data = "Foto actualizada correctamente" };
            }
            else
            {
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
        }

        public async Task<ServiceResponse<bool>> GetDonarUsers(string userEmail)
        {
            bool isUserFromDonar = false;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"https://us-central1-proyecto-final-22cmp.cloudfunctions.net/app/organizaciones/{userEmail}");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    if (content.Length != 0)
                    {
                        content = Regex.Replace(content, @"[{]+\s+[}]|[{]+[}]", "null");

                        JsonSerializerSettings settings = new JsonSerializerSettings
                        {
                            DateFormatString = "yyyy-MM-ddTHH:mm:ss",
                            Culture = new CultureInfo("es-ES"),
                            NullValueHandling = NullValueHandling.Ignore,
                            Formatting = Formatting.Indented
                        };
                        var users = JsonConvert.DeserializeObject<List<DonarOrganizations>>(content, settings);
                        if (users.Count > 0)
                        {
                            var currentUser = this.context.Users.Where(x => x.Email == userEmail).FirstOrDefault();
                            currentUser.IsUserFromDonar = true;
                            this.context.Users.Update(currentUser);
                            await this.context.SaveChangesAsync();
                            //if(users != null) isUserFromDonar = true;
                            isUserFromDonar = true;
                        }
                        else isUserFromDonar = false;
                    }
                    else
                    {
                        isUserFromDonar = false;
                    }
                }
            }
            return new ServiceResponse<bool> { Data = isUserFromDonar };
        }

        public async Task<ServiceResponse<List<UserSearchResultDTO>>> SearchUsersSuggestions(string searchText)
        {
            var users = await FindUsersBySearchText(searchText);

            List<UserSearchResultDTO> result = new List<UserSearchResultDTO>();

            foreach (var user in users)
            {
                if (user.FirstName.Contains(searchText, StringComparison.OrdinalIgnoreCase) || user.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    var usr = new UserSearchResultDTO()
                    {
                        Name = string.Concat(user.FirstName, " ", user.LastName),
                        ProfilePicture = user.ProfilePicture != null ? user.ProfilePicture : string.Empty,
                        UserId = user.Id,
                        IsONGVerified = user.IsONGVerified
                    };

                    result.Add(usr);
                }
            }

            return new ServiceResponse<List<UserSearchResultDTO>> { Data = result };
        }

        public async Task<ServiceResponse<string>> ApproveUserVerification(int userId, string transactionID)
        {
            var response = string.Empty;
            
            var user = this.context.Users.Where(x => x.Id == userId).FirstOrDefault();
            if (user != null)
            {
                user.IsONGVerified = true;
                user.UpdatedDate = DateTime.Now;
                this.context.Users.Update(user);
                var certificates = this.context.Documents.Where(x => x.TransactionID == transactionID).ToList();
                if (certificates.Count > 0)
                {
                    foreach (var certificate in certificates)
                    {
                        certificate.DeletedDate = DateTime.Now;
                        this.context.Documents.Update(certificate);
                    }
                    response = "Se ha verificado la cuenta";
                    await this.notificationService.AddNotification(null, null, user.Email, NotificationTypes.ApproveVerification,null);
                }
                else response = "Ha ocurrido un error";
                await this.context.SaveChangesAsync();
            }
            else response = "Ha ocurrido un error";

            return new ServiceResponse<string> { Data = response };
        }

        public async Task<ServiceResponse<string>> DisapproveUserVerification(int userId, string transactionID)
        {
            var response = string.Empty;

            var user = this.context.Users.Where(x => x.Id == userId).FirstOrDefault();
            if (user != null)
            {
                user.IsONGVerified = false;
                user.UpdatedDate = DateTime.Now;
                this.context.Users.Update(user);
                var certificates = this.context.Documents.Where(x => x.TransactionID == transactionID).ToList();
                if (certificates.Count > 0)
                {
                    foreach (var certificate in certificates)
                    {
                        certificate.DeletedDate = DateTime.Now;
                        this.context.Documents.Update(certificate);
                    }
                    response = "No se aprobó la verificación de la cuenta";
                    await this.notificationService.AddNotification(null, null, user.Email, NotificationTypes.DisapproveVerification,null);
                }
                else response = "Ha ocurrido un error";
                await this.context.SaveChangesAsync();
            }
            else response = "Ha ocurrido un error";

            return new ServiceResponse<string> { Data = response };
        }

        public async Task<ServiceResponse<string>> NotShowGuide(string email)
        {
            var response = string.Empty;

            var user = this.context.Users.Where(x => x.Email == email).FirstOrDefault();
            if (user != null)
            {
                user.NotShowGuide = true;
                user.UpdatedDate = DateTime.Now;
                this.context.Users.Update(user);
                await this.context.SaveChangesAsync();
                response = "No se mostrará la guía nuevamente";
            }
            else response = "Ha ocurrido un error";

            return new ServiceResponse<string> { Data = response };
        }

        #region Private Methods
        private async Task<List<User>> FindUsersBySearchText(string searchText)
        {
            return await this.context.Users
                            .Where(x => x.FirstName.ToLower().Contains(searchText.ToLower()) ||
                                    x.LastName.ToLower().Contains(searchText.ToLower()))
                            .ToListAsync();
        }

        #endregion
    }
}
