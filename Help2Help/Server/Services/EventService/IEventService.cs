namespace Help2Help.Server.Services.EventService
{
    public interface IEventService
    {
        Task<ServiceResponse<List<EventCategory>>> GetEventCategories();
        Task<ServiceResponse<EventCategory>> GetEventCategory(int eventCategoryId);
        Task<ServiceResponse<bool>> CreateEvent(EventResponseDTO request);
        Task<ServiceResponse<Event>> GetEvent(int eventId);
        Task<ServiceResponse<List<EventModel>>> GetEvents();
        Task<ServiceResponse<List<EventResponseDTO>>> GetEventByUserId(int userId);
        Task<ServiceResponse<string>> EditEventInfo(EventResponseDTO request);
        Task<ServiceResponse<string>> DeleteEvent(EventResponseDTO request);
        Task<ServiceResponse<string>> ReportEvent(int eventId, string userEmail);
        Task<ServiceResponse<string>> SynchronizeDonarEvents(string userEmail);
    }
}
