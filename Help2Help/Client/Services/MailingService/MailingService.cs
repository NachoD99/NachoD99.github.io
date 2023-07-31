using Blazored.LocalStorage;
using Help2Help.Shared;
using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Json;

namespace Help2Help.Client.Services.MailingService
{
    public class MailingService : IMailingService
    {
        private readonly HttpClient http;
        private readonly ILocalStorageService localStorage;

        public MailingService(HttpClient http, ILocalStorageService localStorage)
        {
            this.http = http;
            this.localStorage = localStorage;
        }

        public async Task<ServiceResponse<string>> SendMail(string request)
        {
            var result = await this.http.GetFromJsonAsync<ServiceResponse<string>>($"api/mailing/send-mail/{request}");

            var code = await this.localStorage.GetItemAsync<string>("code");

            if (code == null) code = result.Data;

            await this.localStorage.SetItemAsync("code", code);

            return result;
        }

        public async Task<ServiceResponse<string>> SendSupportQuestion(string message)
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");

            var request = new MailRequestDTO()
            {
                Jwt = token != null ? token : string.Empty,
                Message = message
            };

            var response = await this.http.PostAsJsonAsync("api/mailing/send-question", request);

            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<string>>();


            return result;
        }
    }
}
