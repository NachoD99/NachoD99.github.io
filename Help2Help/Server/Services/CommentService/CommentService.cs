namespace Help2Help.Server.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly DataContext context;
        private readonly INotificationService notificationService;

        public CommentService(DataContext context, INotificationService notificationService)
        {
            this.context = context;
            this.notificationService = notificationService;
        }

        public async Task<ServiceResponse<CommentResponseDto>> AddComment(int publicationId, string message, string userEmail)
        {
            var user = await this.context.Users.Where(x => x.Email == userEmail).FirstOrDefaultAsync();

            if (user != null)
            {
                var comment = new Comment()
                {
                    Message = message,
                    PublicationId = publicationId,
                    CreatedDate = DateTime.Now,
                    UserId = user.Id,
                    UserName = string.Concat(user.FirstName, " ", user.LastName),
                    UserProfilePicture = user.ProfilePicture
                };
                await this.context.Comments.AddAsync(comment);
                await this.context.SaveChangesAsync();
                var publication = await this.context.Publications.Where(x => x.Id == publicationId).FirstOrDefaultAsync();

                if(publication != null)
                {
                    publication.Comments.Add(comment);

                    this.context.Publications.Update(publication);
                    await this.context.SaveChangesAsync();

                    await this.notificationService.AddNotification(publication.Id, publication.UserId, userEmail, NotificationTypes.Comment, null);
                }
                return new ServiceResponse<CommentResponseDto>
                {
                    Data = new CommentResponseDto() 
                    { 
                        PublicationId = publication.Id, 
                        Message = comment.Message,
                        UserName = string.Concat(user.FirstName, " ", user.LastName),
                        UserProfilePicture = user.ProfilePicture
                    }
                };
            }
            else
            {
                return new ServiceResponse<CommentResponseDto>();
            }
        }
    }
}
