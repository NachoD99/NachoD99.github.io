global using Help2Help.Shared;
global using Help2Help.Shared.DTO;
global using System.Net.Http.Json;
global using Help2Help.Client.Services;
global using Help2Help.Client.Services.PublicationService.PublicationService;
global using Help2Help.Client.Services.LikeService;
global using Help2Help.Client.Services.AuthService;
global using Help2Help.Client.Services.MapService;
global using Help2Help.Client.Services.EventService;
global using Help2Help.Client.Services.AnalyticService;
global using Help2Help.Client.Services.CommentService;
global using Help2Help.Client.Services.NotificationService;
global using Help2Help.Client.Services.DocumentService;
global using Help2Help.Client.Services.MailingService;
global using Help2Help.Client.Services.UserService;
using Microsoft.AspNetCore.Components.Authorization;
using Help2Help.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

#region Injección de servicios
builder.Services.AddScoped<IPublicationService, PublicationService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IMapService, MapService>();
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IAnalyticService, AnalyticService>();
builder.Services.AddScoped<ILikeService, LikeService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IDocumentService, DocumentService>();
builder.Services.AddScoped<IMailingService, MailingService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
#endregion

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


await builder.Build().RunAsync();
