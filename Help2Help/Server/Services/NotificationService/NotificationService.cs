namespace Help2Help.Server.Services.NotificationService
{
    public class NotificationService : INotificationService
    {
        private readonly DataContext context;

        public NotificationService(DataContext context)
        {
            this.context = context;
        }

        public async Task AddNotification(int? publicationId, int? ownerUserId, string currentUserEmail, NotificationTypes notificationType, string? eventTitle)
        {
            var notification = new Notification();
            var user = await this.context.Users.Where(x => x.Email == currentUserEmail).FirstOrDefaultAsync();

            if (user != null)
            {
                var ownerUser = await this.context.Users.Where(x => x.Id == ownerUserId).FirstOrDefaultAsync();
                if(ownerUser == null)
                {
                    //Para notificaciones que no involucren a otros usuarios
                     notification.UserEmail = currentUserEmail;
                     notification.CreatedDate = DateTime.Now;
                }
                else
                {
                    notification.UserEmail = ownerUser.Email;
                    notification.CreatedDate = DateTime.Now;
                    notification.PublicationId = (int)publicationId;
                }

                switch(notificationType)
                {
                    case NotificationTypes.Like:
                        notification.Message = string.Concat(user.FirstName, " ", user.LastName, " ha dado like a tu publicación.");
                        break;
                    case NotificationTypes.Comment:
                        notification.Message = string.Concat("El usuario ", user.FirstName, " ", user.LastName, " ha comentado en tu publicación.");
                        break;
                    case NotificationTypes.Event:
                        notification.Message = string.Concat("Has creado 1 nuevo evento");
                        break;
                    case NotificationTypes.Donation:
                        notification.Message = string.Concat("Has recibido una nueva donación anónima");
                        break;
                    case NotificationTypes.RequestVerification:
                        notification.Message = string.Concat("Has solicitado la verificación de tu cuenta");
                        break;
                    case NotificationTypes.ApproveVerification:
                        notification.Message = string.Concat("¡Felicidades! Tu cuenta ha sido verificada");
                        break;
                    case NotificationTypes.DisapproveVerification:
                        notification.Message = string.Concat("¡Lo sentimos! Tu cuenta no ha sido verificada");
                        break;
                    case NotificationTypes.EventDeadline:
                        notification.Message = string.Concat("¡Tu evento '",eventTitle, "' está por vencer! Haz una publicación para mostrar tus resultados");
                        break;

                }
                await this.context.Notifications.AddAsync(notification);

                await this.context.SaveChangesAsync();

                return;
            }
            else
            {
                return;
            }
        }

        public async Task<ServiceResponse<List<NotificationResponseDto>>> GetNotifications(string userEmail)
        {
            var response = new ServiceResponse<List<NotificationResponseDto>>();
            response.Data = new List<NotificationResponseDto>();

            var notifications = await this.context.Notifications.Where(x => x.UserEmail == userEmail && x.DeletedDate == null)
                .OrderByDescending(r => r.CreatedDate).ToListAsync();

            if (notifications != null || notifications.Count() > 0)
            {
                foreach (var notification in notifications.Take(20))
                {
                    response.Data.Add( new NotificationResponseDto()
                    {
                        Message = notification.Message
                    });
                }
                return response;
            }
            else
            {
                return new ServiceResponse<List<NotificationResponseDto>>();
            }
        }

        public async Task<ServiceResponse<NotificationResponseDto>> AddDeadlineEventNotification(string userEmail)
        {
            var response = new ServiceResponse<NotificationResponseDto>();
            response.Data = new NotificationResponseDto();

            var user = await this.context.Users.Where(x => x.Email == userEmail).FirstOrDefaultAsync();

            //Debo traer aquellos eventos cuya fecha sea menor a los 3 días posteriores a la fecha actual
            var events = await this.context.Events
                .Where(x => x.UserId == user.Id && x.EndDate < DateTime.Now.AddDays(3))
                .ToListAsync();

            if (events.Count() > 0)
            {
                foreach (var item in events)
                {
                    if (!item.DeadLineNotificationSent)
                    {
                        await this.AddNotification(null, null, userEmail, NotificationTypes.EventDeadline, item.Title);

                        item.DeadLineNotificationSent = true;
                        item.UpdatedDate = DateTime.Now;

                        this.context.Events.Update(item);
                        await this.context.SaveChangesAsync();
                    }
                }
                response.Data.Message = "Notificación creada con éxito";
                return response;
            }
            else
            {
                return new ServiceResponse<NotificationResponseDto>();
            }
        }
    }
}
