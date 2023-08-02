using Google.Analytics.Data.V1Beta;
using System;

namespace Help2Help.Server.Services.PublicationService
{
    public class PublicationService : IPublicationService
    {
        private readonly DataContext context;

        public PublicationService(DataContext context)
        {
            this.context = context;
        }

        //public async Task<ServiceResponse<Publication>> GetPublicationAsync(int publicationId)
        //{
        //    var response = new ServiceResponse<Publication>();
        //    var publication = await this.context.Publications
        //        .FirstOrDefaultAsync(x => x.Id == publicationId);
        //    if (publication == null)
        //    {
        //        response.Success = false;
        //        response.Message = "La publicación no existe";
        //    }
        //    else
        //    {
        //        response.Data = publication;
        //    }

        //    return response;
        //}
        public async Task<ServiceResponse<Publication>> CreatePublication(PublicationResponseDTO request)
        {
            try
            {
                var userId = this.context.Users.Where(x => x.Email == request.Email).FirstOrDefault().Id;

                var publication = new Publication()
                {
                    Description = request.Description,
                    UserId = userId,
                    CreatedDate = DateTime.Now,
                };

                foreach(var image in request.Images)
                {
                    publication.Images.Add(image);
                }

                this.context.Publications.Add(publication);
                await this.context.SaveChangesAsync();

                return new ServiceResponse<Publication> { Data = publication, Message = "¡La publicación se ha creado correctamente!" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Publication> { Success = false, Message = "¡Ha ocurrido un error: " + ex.Message + " !" };
            }

        }

        public async Task<ServiceResponse<List<PublicationResponseDTO>>> GetPublicationsByUser(int usrId, string currentUserMail)
        {
            var response = new ServiceResponse<List<PublicationResponseDTO>>();
            response.Data = new List<PublicationResponseDTO>();
            
            var publications = await this.context.Publications.Where(x => x.UserId == usrId && x.DeletedDate == null)
                    .Include(v => v.Images).Include(c => c.Comments).ToListAsync();

            if (publications.Count > 0)
            {
                foreach (var publication in publications)
                {
                    if(publication.Comments.Count > 0) publication.Comments.OrderBy(x => x.CreatedDate);
                    
                    var like = this.context.Likes
                        .Where(x => x.PublicationId == publication.Id)
                        .OrderByDescending(r => r.UpdatedDate)
                        .FirstOrDefault();

                    var userLiked = this.context.Likes
                        .Where(x => x.PublicationId == publication.Id && x.UserEmail == currentUserMail)
                        .OrderByDescending(r => r.UpdatedDate)
                        .FirstOrDefault();

                    if(userLiked != null)
                    {
                        var pub = new PublicationResponseDTO
                        {
                            Id = publication.Id,
                            Description = publication.Description,
                            Images = publication.Images,
                            CreatedDate = publication.CreatedDate,
                            Like = {
                            Count = like != null ? like.Count : 0,
                            Liked = userLiked.Liked
                            }
                        };

                        var destination = await Task.Run(() =>
                        {
                            var destinationItems = new List<CommentResponseDto>();
                            Parallel.ForEach(publication.Comments, sourceItem =>
                            {
                                var destinationItem = new CommentResponseDto();
                                destinationItem.Message = sourceItem.Message;
                                destinationItem.UserName = sourceItem.UserName;
                                destinationItem.UserProfilePicture = sourceItem.UserProfilePicture;
                                destinationItems.Add(destinationItem);
                            });
                            return destinationItems;
                        });

                        pub.Comments = destination;

                        response.Data.Add(pub);
                        response.Data.OrderByDescending(x => x.Id).ToList();
                    }
                    else
                    {
                        var pub = new PublicationResponseDTO
                        {
                            Id = publication.Id,
                            Description = publication.Description,
                            Images = publication.Images,
                            CreatedDate = publication.CreatedDate,
                            Like = {
                            Count = like != null ? like.Count : 0,
                            Liked = false
                            }
                        };

                        var destination = await Task.Run(() =>
                        {
                            var destinationItems = new List<CommentResponseDto>();
                            Parallel.ForEach(publication.Comments, sourceItem =>
                            {
                                var destinationItem = new CommentResponseDto();
                                destinationItem.Message = sourceItem.Message;
                                destinationItem.UserName = sourceItem.UserName;
                                destinationItem.UserProfilePicture = sourceItem.UserProfilePicture;
                                destinationItems.Add(destinationItem);
                            });
                            return destinationItems;
                        });

                        pub.Comments = destination;

                        response.Data.Add(pub);
                        response.Data.OrderByDescending(x => x.Id).ToList();
                    }
                }
            }
            else
            {
                response.Data = new List<PublicationResponseDTO>();
                response.Success = false;
                response.Message = "Este usuario aún no realizó publicaciones";
            }

            return response;
        }

        public async Task<ServiceResponse<string>> EditPublicationInfo(PublicationResponseDTO request)
        {
            if (request != null)
            {
                var publicationFromDb = this.context.Publications.Where(x => x.Id == request.Id).FirstOrDefaultAsync().Result;

                if (publicationFromDb != null)
                {
                    publicationFromDb.Description = request.Description;
                    publicationFromDb.UpdatedDate = DateTime.Now;
                    publicationFromDb.Images = request.Images;

                    this.context.Publications.Update(publicationFromDb);
                    await this.context.SaveChangesAsync();

                    return new ServiceResponse<string> { Data = "Cambios efectuados correctamente" };
                }
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
            else
            {
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
        }

        public async Task<ServiceResponse<string>> DeletePublication(PublicationResponseDTO request)
        {
            if (request != null)
            {
                var publicationFromDb = this.context.Publications.Where(x => x.Id == request.Id).FirstOrDefaultAsync().Result;

                if (publicationFromDb != null)
                {
                    publicationFromDb.DeletedDate = DateTime.Now;

                    this.context.Publications.Update(publicationFromDb);
                    await this.context.SaveChangesAsync();

                    return new ServiceResponse<string> { Data = "Publicación eliminada exitosamente" };
                }
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
            else
            {
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
        }

        //public async Task<ServiceResponse<List<Publication>>> GetPublicationsByCategory(string categoryUrl)
        //{
        //    var response = new ServiceResponse<List<Publication>>
        //    {
        //        Data = await this.context.Publications
        //        .Where(x => x.Category.Url.ToLower()
        //        .Equals(categoryUrl.ToLower()))
        //        .Include(v => v.Variants)
        //        .ToListAsync()
        //    };
        //    return response;
        //}

        //public async Task<ServiceResponse<PublicationSearchResultDTO>> SearchPublications(string searchText, int page)
        //{
        //    var pageResults = 2f;
        //    var pageCount = Math.Ceiling((await FindPublicationsBySearchText(searchText)).Count / pageResults);
        //    var publications = await this.context.Publications
        //                    .Where(x => x.Name.ToLower().Contains(searchText.ToLower()) ||
        //                            x.Description.ToLower().Contains(searchText.ToLower()))
        //                    .Include(x => x.Variants)
        //                    .Skip((page - 1) * (int)pageResults)
        //                    .Take((int)pageResults)
        //                    .ToListAsync();

        //    var response = new ServiceResponse<PublicationSearchResultDTO>
        //    {
        //        Data = new PublicationSearchResultDTO 
        //        {
        //            Publications = publications,
        //            CurrentPage = page,
        //            Pages = (int)pageCount
        //        }
        //    };

        //    return response;
        //}

        //private async Task<List<Publication>> FindPublicationsBySearchText(string searchText)
        //{
        //    return await this.context.Publications
        //                    .Where(x => x.Name.ToLower().Contains(searchText.ToLower()) ||
        //                            x.Description.ToLower().Contains(searchText.ToLower()))
        //                    .Include(x => x.Variants)
        //                    .ToListAsync();
        //}

        //public async Task<ServiceResponse<List<string>>> SearchPublicationsSuggestions(string searchText)
        //{
        //    var publications = await FindPublicationsBySearchText(searchText);

        //    List<string> result = new List<string>();

        //    foreach (var publication in publications)
        //    {
        //        if(publication.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
        //        {
        //            result.Add(publication.Name);
        //        }

        //        if(publication.Description != null)
        //        {
        //            var punctuation = publication.Description.Where(char.IsPunctuation)
        //                .Distinct().ToArray();
        //            var words = publication.Description.Split()
        //                .Select(s => s.Trim(punctuation));

        //            foreach (var word in words)
        //            {
        //                if(word.Contains(searchText, StringComparison.OrdinalIgnoreCase)
        //                    && !result.Contains(word))
        //                {
        //                    result.Add(word);
        //                }
        //            }
        //        }
        //    }

        //    return new ServiceResponse<List<string>> { Data = result };
        //}

        //public async Task<ServiceResponse<List<Publication>>> GetFeaturedPublications()
        //{
        //    var response = new ServiceResponse<List<Publication>>
        //    {
        //        Data = await this.context.Publications
        //        .Where(x => x.Featured)
        //        .Include(v => v.Variants)
        //        .ToListAsync()
        //    };
        //    return response;
        //}
    }
}
