
using Blazored.LocalStorage;

namespace Help2Help.Client.Services.NotificationService
{
    public class NotificationService : INotificationService
    {
        private readonly HttpClient http;
        private readonly ILocalStorageService localStorage;

        public event Action OnChange;
        public List<NotificationResponseDto> Notifications { get; set; } = new List<NotificationResponseDto>();
        public NotificationService(HttpClient http, ILocalStorageService localStorage)
        {
            this.http = http;
            this.localStorage = localStorage;
        }

        public async Task<List<NotificationResponseDto>> GetNotifications()
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");
            var request = new NotificationResponseDto() 
            { 
                Jwt = token != null ? token : string.Empty 
            };
            var response = await this.http.PostAsJsonAsync("api/notification", request);

            var notifications = await response.Content.ReadFromJsonAsync<ServiceResponse<List<NotificationResponseDto>>>();

            Notifications = notifications.Data;

            return Notifications;
        }

        public async Task AddDeadlineEventNotification()
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");
            var request = new NotificationResponseDto()
            {
                Jwt = token != null ? token : string.Empty
            };
            var response = await this.http.PostAsJsonAsync("api/notification/add-event-notification", request);

            var notifications = await response.Content.ReadFromJsonAsync<ServiceResponse<NotificationResponseDto>>();

        }

    }
}
