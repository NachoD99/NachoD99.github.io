namespace Help2Help.Server.Services.LikeService
{
    public interface ILikeService
    {
        Task<ServiceResponse<LikeResponseDto>> CheckLike(int publicationId, string userEmail);
    }
}
