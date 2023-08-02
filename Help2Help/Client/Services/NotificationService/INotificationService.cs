namespace Help2Help.Client.Services.NotificationService
{
    public interface INotificationService
    {
        event Action OnChange;
        List<NotificationResponseDto> Notifications { get; set; }
        Task<List<NotificationResponseDto>> GetNotifications();
        Task AddDeadlineEventNotification();
    }
}
