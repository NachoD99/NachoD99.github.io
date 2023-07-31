namespace Help2Help.Client.Services.CommentService
{
    public interface ICommentService
    {
        event Action OnChange;
        Task<List<CommentResponseDto>> AddComment(int publicationId, string message);
    }
}
