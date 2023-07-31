namespace Help2Help.Server.Services.LikeService
{
    public class LikeService : ILikeService
    {
        private readonly DataContext context;
        private readonly INotificationService notificationService;

        public LikeService(DataContext context, INotificationService notificationService)
        {
            this.context = context;
            this.notificationService = notificationService;
        }

        public async Task<ServiceResponse<LikeResponseDto>> CheckLike(int publicationId, string userEmail)
        {
            var response = new ServiceResponse<LikeResponseDto>();
            response.Data = new LikeResponseDto();

            var like = await this.context.Likes.Where(x => x.PublicationId == publicationId && x.UserEmail == userEmail)
                .OrderByDescending(r => r.UpdatedDate).FirstOrDefaultAsync();

            if (like == null)
            {
                //si es null quiere decir que es la primer vez que el usuario da like a esta publicacion

                //busco si esa publicacion ya posee like de otro usuario y me quedo con el ultimo registro
                var lastLike = this.context.Likes
                            .Where(x => x.PublicationId == publicationId)
                            .OrderByDescending(r => r.UpdatedDate)
                            .FirstOrDefault();

                //Si ya tenia likes actualizo el contador, sino le asigno el primer like
                var newLike = new Like()
                {
                    PublicationId = publicationId,
                    UserEmail = userEmail,
                    Liked = true,
                    Count = lastLike != null ? ++lastLike.Count : 1,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now
                };
                await this.context.Likes.AddAsync(newLike);

                var publication = await this.context.Publications.Where(x => x.Id == publicationId).FirstOrDefaultAsync();

                if (publication != null)
                {
                    publication.LikesCount = newLike.Count;
                    publication.UpdatedDate = DateTime.Now;

                    this.context.Publications.Update(publication);

                    await this.notificationService.AddNotification(publication.Id, publication.UserId, userEmail, NotificationTypes.Like, null);
                }
                await this.context.SaveChangesAsync();

                return new ServiceResponse<LikeResponseDto>
                {
                    Data = new LikeResponseDto() { Liked = newLike.Liked, Count = publication.LikesCount }
                };
            }
            else
            {
                //busco el ultimo like si o si para obtener el ultimo resultado del contador
                var lastLike = this.context.Likes
                        .Where(x => x.PublicationId == publicationId)
                        .OrderByDescending(r => r.UpdatedDate)
                        .FirstOrDefault();

                //si el usuario tiene registro de haber likeado esa pub, corroborar que el ultimo este en true o false
                //Si esta en true, la ultima reaccion es haberle dado like → hay que descontarlo
                if (like.Liked)
                {
                    like.Liked = false;
                    like.Count = lastLike != null ? --lastLike.Count : 0;
                    like.UpdatedDate = DateTime.Now;
                }
                else
                {
                    //Si el ultimo registro esta en false, hay que volver a sumarlo
                    like.Liked = true;
                    like.Count = lastLike != null ? ++lastLike.Count : 1;
                    like.UpdatedDate = DateTime.Now;
                }


                this.context.Likes.Update(like);

                var publication = await this.context.Publications.Where(x => x.Id == publicationId).FirstOrDefaultAsync();

                if (publication != null)
                {
                    publication.LikesCount = like.Count;
                    publication.UpdatedDate = DateTime.Now;

                    this.context.Publications.Update(publication);

                    //Solo notificar cuando se agrega el like, no cuando lo quita
                    if(!like.Liked) await this.notificationService.AddNotification(publication.Id, publication.UserId, userEmail, NotificationTypes.Like, null);
                }

                await this.context.SaveChangesAsync();

                return new ServiceResponse<LikeResponseDto>
                {
                    Data = new LikeResponseDto() { Liked = like.Liked, Count = publication.LikesCount }
                };
            }

        }

        //public async Task RemoveLike(int resourceId, string userId)
        //{
        //    var like = await this.context.Likes.FirstOrDefaultAsync(l => l.ResourceId == resourceId && l.UserId == userId);

        //    if (like != null)
        //    {
        //        this.context.Likes.Remove(like);
        //        await this.context.SaveChangesAsync();
        //    }
        //}

        //public async Task<List<Like>> GetLikesForResource(int resourceId)
        //{
        //    return await this.context.Likes.Where(l => l.ResourceId == resourceId).ToListAsync();
        //}
    }
}
