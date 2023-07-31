namespace Help2Help.Client.Services.EventService
{
    public interface IEventService
    {
        List<EventCategory> Categories { get; set; }
        Task<List<EventCategory>> GetEventCategories();
        Task<bool> CreateEvent(EventResponseDTO request);
        Task<bool> GetEventByUserId(int userId);
        Task<ServiceResponse<string>> EditEventInfo(EventResponseDTO request);
        Task<ServiceResponse<string>> DeleteEvent(EventResponseDTO request);
        Task<ServiceResponse<string>> ReportEvent(int eventId);
        Task<ServiceResponse<string>> SynchronizeDonarEvents();
        public List<EventResponseDTO> Events { get; set; }
        public event Action EventsChanged;
    }
}
