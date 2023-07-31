namespace Help2Help.Server.Services.NotificationService
{
    public interface INotificationService
    {
        Task AddNotification(int? publicationId, int? ownerUserId, string currentUserEmail, NotificationTypes notificationType, string? eventTitle);
        Task<ServiceResponse<List<NotificationResponseDto>>> GetNotifications(string userEmail);
        Task<ServiceResponse<NotificationResponseDto>> AddDeadlineEventNotification(string userEmail);
    }
}
