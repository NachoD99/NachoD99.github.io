namespace Help2Help.Client.Services.LikeService
{
    public interface ILikeService
    {
        event Action OnChange;
        Task<ServiceResponse<LikeResponseDto>> CheckLike(int publicationId);
    }
}
