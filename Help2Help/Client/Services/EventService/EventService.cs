using Blazored.LocalStorage;

namespace Help2Help.Client.Services.EventService
{
    public class EventService : IEventService
    {
        private readonly HttpClient http;
        private readonly ILocalStorageService localStorage;

        public EventService(ILocalStorageService localStorage, HttpClient http)
        {
            this.http = http;
            this.localStorage = localStorage;
        }
        public List<EventCategory> Categories { get; set; } = new List<EventCategory>();
        public List<EventResponseDTO> Events { get; set; } = new List<EventResponseDTO>();
        public event Action EventsChanged;
        public async Task<List<EventCategory>> GetEventCategories()
        {
            var response = await this.http.PostAsJsonAsync("api/event/categories", 1);

            var categories = await response.Content.ReadFromJsonAsync<ServiceResponse<List<EventCategory>>>();
            Categories = categories.Data;
            return categories.Data;
        }

        public async Task<bool> CreateEvent(EventResponseDTO request)
        {
            var latitude = await this.localStorage.GetItemAsync<decimal>("latitud");
            request.CoordinateY = latitude;
            var longitude = await this.localStorage.GetItemAsync<decimal>("longitud");
            request.CoordinateX = longitude;
            var response = await this.http.PostAsJsonAsync("api/event/new", request);

            var x = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return x.Data;
        }

        public async Task<bool> GetEventByUserId(int userId)
        {
            var result =
                await this.http.GetFromJsonAsync<ServiceResponse<List<EventResponseDTO>>>($"api/event/get-event-by-user-id/{userId}");

            if (result != null && result.Data?.Count > 0)
            {
                    Events = result.Data;
                    return true;
            }
            else return false;

        }
 
        public async Task<ServiceResponse<string>> EditEventInfo(EventResponseDTO request)
        {
            var result = await this.http.PostAsJsonAsync("api/event/edit-info", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<string>> DeleteEvent(EventResponseDTO request)
        {
            var result = await this.http.PostAsJsonAsync("api/event/delete", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<string>> ReportEvent(int eventId)
        {
            string jwt = await this.localStorage.GetItemAsync<string>("authToken");

            var request = new ReportEventResponseDto()
            {
                EventId = eventId,
                Jwt = jwt != null ? jwt : string.Empty
            };
            var response = await this.http.PostAsJsonAsync("api/event/report", request);

            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<string>>();

            return result;
        }

        public async Task<ServiceResponse<string>> SynchronizeDonarEvents()
        {
            string jwt = await this.localStorage.GetItemAsync<string>("authToken");

            var request = new ReportEventResponseDto()
            {
                Jwt = jwt != null ? jwt : string.Empty
            };
            var response = await this.http.PostAsJsonAsync("api/event/synchronize", request);

            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<string>>();

            return result;
        }
    }
}
