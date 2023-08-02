using Newtonsoft.Json;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Help2Help.Server.Services.EventService
{
    public class EventService : IEventService
    {
        private readonly DataContext context;
        private readonly INotificationService notificationService;

        public EventService(DataContext context, INotificationService notificationService)
        {
            this.context = context;
            this.notificationService = notificationService;
        }

        public async Task<ServiceResponse<List<EventCategory>>> GetEventCategories()
        {
            var result = new ServiceResponse<List<EventCategory>>
            {
                Data = new List<EventCategory>()
            };

            var eventCategories = await this.context.EventCategories.Where(x => x.Id != 56).ToListAsync();

            foreach (var category in eventCategories)
            {

                result.Data.Add(category);

            }
            return result;
        }

        public async Task<ServiceResponse<EventCategory>> GetEventCategory(int eventCategoryId)
        {
            var result = new ServiceResponse<EventCategory>
            {
                Data = new EventCategory()
            };

            var eventCategory = await this.context.EventCategories
                .Where(x => x.Id == eventCategoryId).SingleOrDefaultAsync();

            result.Data = eventCategory;

            return result;
        }

        public async Task<ServiceResponse<bool>> CreateEvent(EventResponseDTO request)
        {
            try
            {
                var userId = this.context.Users.Where(x => x.Email == request.Email).FirstOrDefault().Id;
                var categoryId = this.context.EventCategories.Where(x => x.FatherCategory == request.FatherCategory
                && x.Name == request.MainCategory && x.SubCategory == request.SubCategory).FirstOrDefault().Id;

                var newEvent = new Event()
                {
                    Title = request.Title,
                    Description = request.Description,
                    UserId = userId,
                    EventCategoryId = categoryId,
                    MercadoPagoLink = request.MercadoPagoLink != string.Empty ? request.MercadoPagoLink : string.Empty, //Solo para eventos de Dinero
                    StartDate = request.StartDate,
                    EndDate = request.EndDate,
                    CreatedDate = DateTime.Now
                };

                this.context.Events.Add(newEvent);
                await this.context.SaveChangesAsync();

                var map = new Map()
                {
                    CoordinateX = request.CoordinateX,
                    CoordinateY = request.CoordinateY,
                    Country = "Argentina",
                    Province = request.Province,
                    Locality = request.City,
                    ZipCode = request.ZipCode,
                    Street = request.Street,
                    StreetNumber = request.StreetNumber,
                    EventCategoryId = categoryId,
                    EventId = newEvent.Id,
                    CreatedDate = DateTime.Now
                };

                this.context.Maps.Add(map);
                await this.context.SaveChangesAsync();
                await this.notificationService.AddNotification(null, null, request.Email, NotificationTypes.Event, null);
                return new ServiceResponse<bool> { Data = true, Message = "¡Se ha registrado correctamente!" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<bool> { Data = false, Message = "¡Ha ocurrido un error: " + ex.Message + " !" };
            }

        }

        public async Task<ServiceResponse<Event>> GetEvent(int eventId)
        {
            var result = new ServiceResponse<Event>
            {
                Data = new Event()
            };

            var eventCategory = await this.context.Events.Where(x => x.Id == eventId && x.DeletedDate == null && x.EndDate > DateTime.Now).SingleOrDefaultAsync();

            result.Data = eventCategory;

            return result;
        }

        public async Task<ServiceResponse<List<EventModel>>> GetEvents()
        {
            var result = new ServiceResponse<List<EventModel>>
            {
                Data = new List<EventModel>()
            };

            try
            {
                var events = await this.context.Events.Where(x => x.DeletedDate == null 
                                && x.EndDate > DateTime.Now && x.EventCategoryId != 56).ToListAsync();

                foreach (var evnt in events)
                {
                    var user = await this.context.Users.Where(x => x.Id == evnt.UserId && x.DeletedDate == null).FirstOrDefaultAsync();
                    var eventCategory = await this.context.EventCategories
                        .Where(x => x.Id == evnt.EventCategoryId).FirstOrDefaultAsync();
                    var location = await this.context.Maps.Where(x => x.EventId == evnt.Id).FirstOrDefaultAsync();

                    var model = new Shared.API.EventModel()
                    {
                        Id = evnt.Id,
                        EventTitle = evnt.Title,
                        EventDescription = evnt.Description,
                        EventDateCreated = evnt.CreatedDate,
                        UserName = user != null ? string.Concat(user.FirstName, " ", user.LastName) : string.Empty,
                        FatherCategory = eventCategory != null ? eventCategory.FatherCategory : string.Empty,
                        Category = eventCategory != null ? eventCategory.Name : string.Empty,
                        SubCategory = (eventCategory != null && eventCategory.SubCategory != null) ? eventCategory.SubCategory : string.Empty,
                        Country = location != null ? location.Country : string.Empty,
                        Province = location != null ? location.Province : string.Empty,
                        City = location != null ? location.Locality : string.Empty,
                        Street = location != null ? location.Street : string.Empty,
                        StreetNumber = location != null ? location.StreetNumber : 0,
                        StartDate = evnt.StartDate,
                        EndDate = evnt.EndDate
                    };

                    result.Data.Add(model);
                }

                result.Success = true;
                return result;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                return result;
            }

        }

        public async Task<ServiceResponse<List<EventResponseDTO>>> GetEventByUserId(int userId)
        {
            var result = new ServiceResponse<List<EventResponseDTO>>
            {
                Data = new List<EventResponseDTO>()
            };

            var events = await this.context.Events.Where(x => x.UserId == userId && x.DeletedDate == null && x.EndDate > DateTime.Now).ToListAsync();

            if (events.Count > 0)
            {
                foreach (var eventToList in events)
                {
                    var eventCategory = await this.context.EventCategories
                        .Where(x => x.Id == eventToList.EventCategoryId).FirstOrDefaultAsync();


                    var eventDirection = await this.context.Maps
                        .Where(x => x.EventId == eventToList.Id).FirstOrDefaultAsync();

                    result.Data.Add(new EventResponseDTO()
                    {
                        Id = eventToList.Id,
                        Title = eventToList.Title,
                        Description = eventToList.Description,
                        Street = eventDirection != null ? eventDirection.Street : string.Empty,
                        StreetNumber = eventDirection != null ? eventDirection.StreetNumber : 0,
                        City = eventDirection != null ? eventDirection.Locality : string.Empty,
                        Province = eventDirection != null ? eventDirection.Province : string.Empty,
                        ZipCode = eventDirection != null ? eventDirection.ZipCode : 0,
                        FatherCategory = eventCategory?.FatherCategory != null ? eventCategory.FatherCategory : string.Empty,
                        MainCategory = eventCategory?.Name != null ? eventCategory.Name : string.Empty,
                        SubCategory = eventCategory?.SubCategory != null ? eventCategory.SubCategory : string.Empty,
                        StartDate = eventToList.StartDate,
                        EndDate = eventToList.EndDate,
                        MercadoPagoLink = eventToList.MercadoPagoLink,
                    });
                }
            }

            return result;
        }

        public async Task<ServiceResponse<string>> EditEventInfo(EventResponseDTO request)
        {
            if (request != null)
            {
                var eventFromDb = this.context.Events.Where(x => x.Id == request.Id).FirstOrDefaultAsync().Result;
                var mapFromDb = this.context.Maps.Where(x => x.EventId == request.Id).FirstOrDefaultAsync().Result;
                var categoryId = context.EventCategories.Where(x => x.FatherCategory == request.FatherCategory
                    && x.Name == request.MainCategory && x.SubCategory == request.SubCategory).FirstOrDefault()?.Id;

                if (eventFromDb != null & (categoryId != 0 || categoryId != null))
                {
                    eventFromDb.Title = request.Title;
                    eventFromDb.Description = request.Description;
                    eventFromDb.EventCategoryId = (int)categoryId;
                    eventFromDb.StartDate = request.StartDate;
                    eventFromDb.EndDate = request.EndDate;
                    eventFromDb.MercadoPagoLink = request.MercadoPagoLink;
                    eventFromDb.UpdatedDate = DateTime.Now;

                    mapFromDb.Street = request.Street;
                    mapFromDb.StreetNumber = request.StreetNumber;
                    mapFromDb.Province = request.Province;
                    mapFromDb.Locality = request.City;
                    mapFromDb.ZipCode = request.ZipCode;
                    mapFromDb.UpdatedDate = DateTime.Now;

                    this.context.Events.Update(eventFromDb);
                    this.context.Maps.Update(mapFromDb);
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

        public async Task<ServiceResponse<string>> DeleteEvent(EventResponseDTO request)
        {
            if (request != null)
            {
                var eventFromDb = this.context.Events.Where(x => x.Id == request.Id).FirstOrDefaultAsync().Result;

                if (eventFromDb != null)
                {
                    eventFromDb.DeletedDate = DateTime.Now;

                    this.context.Events.Update(eventFromDb);
                    await this.context.SaveChangesAsync();

                    return new ServiceResponse<string> { Data = "Evento eliminado exitosamente" };
                }
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
            else
            {
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
        }

        public async Task<ServiceResponse<string>> ReportEvent(int eventId, string userEmail)
        {
            if (eventId != 0)
            {
                string message = string.Empty;

                var report = await this.context.EventReports.Where(x => x.EventId == eventId && x.UserEmail == userEmail)
                .FirstOrDefaultAsync();

                //Si es nulo es porque este usuario no lo ha reportado previamente
                if (report == null)
                {
                    var lastReports = await this.context.EventReports.Where(x => x.EventId == eventId)
                        .OrderByDescending(r => r.CreatedDate).FirstOrDefaultAsync();

                    if (lastReports == null)
                    {
                        //Si es nulo quiere decir que ese evento todavia no tiene un reporte
                        var newReport = new EventReport()
                        {
                            Count = 1,
                            EventId = eventId,
                            UserEmail = userEmail,
                            CreatedDate = DateTime.Now
                        };

                        await this.context.EventReports.AddAsync(newReport);
                        message = "Se ha reportado este evento y pasará a revisión";
                    }
                    else if (lastReports.Count < 10)
                    {
                        var newReport = new EventReport()
                        {
                            Count = ++lastReports.Count,
                            EventId = eventId,
                            UserEmail = userEmail,
                            CreatedDate = DateTime.Now
                        };
                        await this.context.EventReports.AddAsync(newReport);
                        message = "Se ha reportado este evento y pasará a revisión";
                        //Si con este ultimo reporte ya llego a los 10, elimino el evento
                        if (newReport.Count == 10)
                        {
                            var evento = await this.context.Events.Where(x => x.Id == eventId).FirstOrDefaultAsync();
                            evento.DeletedDate = DateTime.Now;

                            this.context.Events.Update(evento);
                            message = "Se ha eliminado el evento debido a que incumple las normas de la aplicación.";
                        }
                    }
                    else
                    {
                        var evento = await this.context.Events.Where(x => x.Id == eventId).FirstOrDefaultAsync();
                        evento.DeletedDate = DateTime.Now;

                        this.context.Events.Update(evento);
                        message = "Se ha eliminado el evento debido a que incumple las normas de la aplicación.";
                    }
                    await this.context.SaveChangesAsync();


                    return new ServiceResponse<string>
                    {
                        Data = message
                    };
                }
                else
                {
                    //Si encontro un reporte de ese evento, quiere decir que el usuario ya lo reporto anteriormente
                    //y no hay que permitir generar uno nuevo debido a que un usuario solo puede reportar a un solo evento

                    return new ServiceResponse<string>
                    {
                        Data = "Ya has reportado este evento, no es posible reportarlo nuevamente."
                    };
                }
            }
            else
            {
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }


        }

        public async Task<ServiceResponse<string>> SynchronizeDonarEvents(string userEmail)
        {
            if (!string.IsNullOrEmpty(userEmail))
            {
                string message = string.Empty;

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"https://us-central1-proyecto-final-22cmp.cloudfunctions.net/app/necesidades/{userEmail}");

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        content = Regex.Replace(content, @"[{]+\s+[}]|[{]+[}]", "null");

                        JsonSerializerSettings settings = new JsonSerializerSettings
                        {
                            DateFormatString = "yyyy-MM-ddTHH:mm:ss",
                            Culture = new CultureInfo("es-ES"),
                            NullValueHandling = NullValueHandling.Ignore,
                            Formatting = Formatting.Indented
                        };
                        var eventsFromDonar = JsonConvert.DeserializeObject<List<DonarEvents>>(content, settings);

                        if (eventsFromDonar != null && eventsFromDonar.Count > 0)
                        {
                            var user = this.context.Users.Where(x => x.Email == userEmail).FirstOrDefault();
                            user.AllowDonarEvents = true;
                            this.context.Users.Update(user);
                            await this.context.SaveChangesAsync();

                            var eventsToDb = new List<Event>();

                            foreach (var item in eventsFromDonar)
                            {
                                var eventToAdd = new Event()
                                {
                                    Title = item.name,
                                    Description = item.description,
                                    UserId = user.Id,
                                    CreatedDate = DateTime.Now,
                                    EventCategoryId = 56 //Se hardcodea un código especial para los eventos de Donar

                                };

                                this.context.Events.Add(eventToAdd);
                                await this.context.SaveChangesAsync();

                                var coordinates = await GetGoogleCoordinates(item.organizationData.address);

                                string[] locationData = item.organizationData.address.Split(',');

                                var map = new Map()
                                {
                                    CoordinateX = coordinates.CoordinateX,
                                    CoordinateY = coordinates.CoordinateY,
                                    Street = locationData[0].Split(" ").First().Trim(),
                                    StreetNumber = int.Parse(locationData[0].Split(" ").Last().Trim()),
                                    Locality = locationData[1].Trim(),
                                    Province = locationData[2].Trim(),
                                    Country = locationData[3].Trim(),
                                    EventCategoryId = 56,
                                    EventId = eventToAdd.Id,
                                    CreatedDate = DateTime.Now
                                };

                                this.context.Maps.Add(map);
                                await this.context.SaveChangesAsync();
                            }
                        }
                    }
                }

                return new ServiceResponse<string>
                {
                    Data = "¡Felicidades! Se han añadido los eventos"
                };
            }
            else
            {
                return new ServiceResponse<string> { Data = "Ha ocurrido un error", Success = false };
            }
        }


        #region Private Methods
        private async Task<MapResponseDTO> GetGoogleCoordinates(string address)
        {
            var result = new MapResponseDTO();
            try
            {
                var apiKey = "AIzaSyD8fKZgkAw7-yDBfrGiPhm7oyxQCT635HA";
                var encodedAddress = Uri.EscapeDataString(address);
                var url = $"https://maps.googleapis.com/maps/api/geocode/json?address={encodedAddress}&key={apiKey}";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();

                        content = Regex.Replace(content, @"[{]+\s+[}]|[{]+[}]", "null");

                        JsonSerializerSettings settings = new JsonSerializerSettings
                        {
                            DateFormatString = "yyyy-MM-ddTHH:mm:ss",
                            Culture = new CultureInfo("es-ES"),
                            NullValueHandling = NullValueHandling.Ignore,
                            Formatting = Formatting.Indented
                        };
                        var coordinates = JsonConvert.DeserializeObject<GeocodingResponse>(content, settings);

                        result.CoordinateX = (decimal)coordinates.Results.FirstOrDefault().Geometry.Location.Lng;
                        result.CoordinateY = (decimal)coordinates.Results.FirstOrDefault().Geometry.Location.Lat;
                    }
                }
                return result;

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }

        }

        public class GeocodingResponse
        {
            public string Status { get; set; }
            public List<GeocodingResult> Results { get; set; }
        }

        public class GeocodingResult
        {
            public Geometry Geometry { get; set; }
        }

        public class Geometry
        {
            public Location Location { get; set; }
        }

        public class Location
        {
            public double Lat { get; set; }
            public double Lng { get; set; }
        }
        #endregion
    }

}
