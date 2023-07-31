namespace Help2Help.Server.Services.CommentService
{
    public interface ICommentService
    {
        Task<ServiceResponse<CommentResponseDto>> AddComment(int publicationId, string message, string userEmail);
    }
}
