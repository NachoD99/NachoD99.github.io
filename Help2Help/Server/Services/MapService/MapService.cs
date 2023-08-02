using Newtonsoft.Json;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Help2Help.Server.Services.MapService
{
    public class MapService : IMapService
    {
        private readonly DataContext context;
        private readonly IEventService eventService;

        public MapService(DataContext context, IEventService eventService)
        {
            this.context = context;
            this.eventService = eventService;
        }

        public async Task<ServiceResponse<List<MapResponseDTO>>> GetMapMarkers()
        {
            var result = new ServiceResponse<List<MapResponseDTO>>
            {
                Data = new List<MapResponseDTO>()
            };
            try
            {
                var markers = await this.context.Maps.Where(m => m.EventId != 0).ToListAsync();

                if (markers.Count > 0)
                {
                    var count = 0;
                    try
                    {
                        foreach (var marker in markers)
                        {

                            var evento = this.eventService.GetEvent(marker.EventId).Result.Data;

                            if (evento != null)
                            {
                                var category = this.eventService.GetEventCategory(marker.EventCategoryId).Result.Data;
                                var userPhone = this.context.Users.Where(x => x.Id == evento.UserId).FirstOrDefaultAsync().Result?.Phone;
                                if (category != null)
                                {
                                    var markerToMap = new MapResponseDTO
                                    {
                                        CoordinateX = marker.CoordinateX,
                                        CoordinateY = marker.CoordinateY,
                                        Street = string.Concat(marker.Street, " ", marker.StreetNumber, ", ", marker.Locality, ", ", marker.Province, ", Argentina"),
                                        EventCategory = category.SubCategory == string.Empty ? category.Name : category.SubCategory,
                                        UserId = evento != null ? evento.UserId : 0,
                                        UserPhone = userPhone != null ? userPhone : string.Empty,
                                        EventDescription = evento != null ? evento.Description : string.Empty,
                                        EventTitle = evento != null ? evento.Title : string.Empty,
                                        MercadoPagoLink = evento.MercadoPagoLink == string.Empty ? string.Empty : evento.MercadoPagoLink,
                                    };

                                    result.Data.Add(markerToMap);
                                    count++;
                                }
                                else
                                {
                                    var markerToMap = new MapResponseDTO
                                    {
                                        CoordinateX = marker.CoordinateX,
                                        CoordinateY = marker.CoordinateY,
                                        Street = string.Concat(marker.Street, " ", marker.StreetNumber, ", ", marker.Locality, ", ", marker.Province, ", Argentina"),
                                        UserId = evento != null ? evento.UserId : 0,
                                        EventCategory = "Eventos de 'Donar'",
                                        UserPhone = userPhone != null ? userPhone : string.Empty,
                                        EventDescription = evento != null ? evento.Description : string.Empty,
                                        EventTitle = evento != null ? evento.Title : string.Empty
                                    };

                                    result.Data.Add(markerToMap);
                                    count++;
                                }
                            }
                        }
                        return result;
                    }
                    catch (Exception ex)
                    {
                        var dfdfg = ex.Message;
                        var efjfvf = count;
                        throw;
                    }

                }
                else return result;
            }
            catch (Exception ex)
            {
                var dfdfg = ex.Message;
                throw;
            }

        }

        public async Task<ServiceResponse<List<ProvinceResponseDTO>>> GetProvinces()
        {
            var result = new ServiceResponse<List<ProvinceResponseDTO>>
            {
                Data = new List<ProvinceResponseDTO>()
            };
            try
            {
                var provinces = await this.context.Provinces.ToListAsync();

                if (provinces.Count > 0)
                {
                    try
                    {
                        foreach (var province in provinces)
                        {
                            var provinceToMap = new ProvinceResponseDTO
                            {
                                Name = province.Name,
                                ProvinceId = province.ProvinceId,
                            };

                            result.Data.Add(provinceToMap);
                        }
                        return result;
                    }
                    catch (Exception ex)
                    {
                        var x = ex.Message;
                        throw;
                    }
                }
                else return result;
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                throw;
            }
        }

        public async Task<ServiceResponse<List<CityResponseDTO>>> GetCities(string provinceId)
        {
            var result = new ServiceResponse<List<CityResponseDTO>>
            {
                Data = new List<CityResponseDTO>()
            };
            try
            {
                var cities = await this.context.Cities.Where(x => x.ProvinceId == provinceId).ToListAsync();

                if (cities.Count > 0)
                {
                    try
                    {
                        foreach (var city in cities)
                        {
                            var cityToMap = new CityResponseDTO
                            {
                                Name = city.Name,
                                CityId = city.CityId,
                                ProvinceId = city.ProvinceId
                            };

                            result.Data.Add(cityToMap);
                        }
                        return result;
                    }
                    catch (Exception ex)
                    {
                        var x = ex.Message;
                        throw;
                    }
                }
                else return result;
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                throw;
            }
        }

        public async Task SaveProvincesInDb()
        {
            var url = "https://apis.datos.gob.ar/georef/api/provincias";

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

                    Root root = JsonConvert.DeserializeObject<Root>(content, settings);

                    int cantidad = root.cantidad;
                    int total = root.total;
                    List<Provincia> provincias = root.provincias;

                    foreach (Provincia provincia in provincias)
                    {
                        try
                        {
                            var provinceFromDb = this.context.Provinces.Where(x => x.ProvinceId == provincia.id).FirstOrDefault();
                            if (provinceFromDb == null)
                            {
                                var province = new Province()
                                {
                                    ProvinceId = provincia.id,
                                    Name = provincia.nombre,
                                    CreatedDate = DateTime.Now
                                };

                                this.context.Add(province);
                            }
                        }
                        catch (Exception ex)
                        {
                            var x = ex.Message;
                        }

                    }
                    this.context.SaveChangesAsync();
                }
            }
        }

        public async Task SaveCitiesInDb()
        {
            try
            {
                var provinces = this.context.Provinces.ToListAsync();
                foreach (var provincia in provinces.Result)
                {
                    var url = string.Concat("https://apis.datos.gob.ar/georef/api/municipios?provincia=", provincia.ProvinceId, "&max=1000");

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

                            Root2 root = JsonConvert.DeserializeObject<Root2>(content, settings);

                            List<Municipio> municipios = root.municipios;

                            foreach (Municipio municipio in municipios)
                            {
                                var cityFromDb = this.context.Cities.Where(x => x.CityId == municipio.id).FirstOrDefault();
                                if (cityFromDb == null)
                                {
                                    var city = new City()
                                    {
                                        CityId = municipio.id,
                                        Name = municipio.nombre,
                                        ProvinceId = municipio.provincia.id,
                                        CreatedDate = DateTime.Now
                                    };

                                    this.context.Add(city);
                                }
                            }
                        }
                    }
                }
                this.context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var x = ex.Message;
            }
        }
        #region Clases provincia
        public class Centroide
        {
            public double lat { get; set; }
            public double lon { get; set; }
        }

        public class Provincia
        {
            public Centroide centroide { get; set; }
            public string id { get; set; }
            public string nombre { get; set; }
        }

        public class Root
        {
            public int cantidad { get; set; }
            public int inicio { get; set; }
            public object parametros { get; set; }
            public List<Provincia> provincias { get; set; }
            public int total { get; set; }
        }

        #endregion

        #region Clases ciudades
        public class Provincia2
        {
            public string id { get; set; }
            public string nombre { get; set; }
        }

        public class Municipio
        {
            public Centroide centroide { get; set; }
            public string id { get; set; }
            public string nombre { get; set; }
            public Provincia2 provincia { get; set; }
        }

        public class Root2
        {
            public int cantidad { get; set; }
            public int inicio { get; set; }
            public List<Municipio> municipios { get; set; }
            public object parametros { get; set; }
            public int total { get; set; }
        }
        #endregion
    }
}

