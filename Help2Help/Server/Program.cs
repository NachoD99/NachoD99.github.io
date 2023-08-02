global using Help2Help.Shared; //El global using en el program.cs nos simplifica la tarea de llamar a este using en cada uno de los controladores que necesitemos usarlo
global using Microsoft.EntityFrameworkCore;
global using Help2Help.Server.Data;
global using Help2Help.Server.Services.PublicationService;
global using Help2Help.Server.Services.LikeService;
global using Help2Help.Server.Services.AuthService;
global using Help2Help.Server.Services.MapService;
global using Help2Help.Server.Services.EventService;
global using Help2Help.Server.Services.AnalyticService;
global using Help2Help.Server.Services.CommentService;
global using Help2Help.Server.Services.NotificationService;
global using Help2Help.Server.Services.DocumentService;
global using Help2Help.Server.Services.MailingService;
global using Help2Help.Server.Services.UserService;
global using Help2Help.Shared.DTO;
global using Help2Help.Shared.API;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Configuracion base de datos
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
/*
 Paso siguiente es realizar la migración, para esto hay dos formas de hacerlo:

- Code First: de esta manera se crearán los modelos a utilizar y entity framework 
se encargará de crear las tablas en la db

- SQL First: primero se crean las tablas, atributos y relaciones desde la bd y 
entity framework se encargará de crear los modelos

Son dos formas opuestas de lograr el mismo resultado, 
en este caso se utilizará el método de Code First (mayormente el más utilizado)

MIGRACIÓN (Desde Consola de Administrador de Packetes):
1- dotnet ef migrations add CreateInitial
2- dotnet ef database update
 */
#endregion

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

#region Configuración para Swagger UI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

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
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie()
    .AddGoogle(googleOptions =>
    {
        googleOptions.ClientId = "736544891077-eibaa4sh9mtocckakiqilict2ics48tn.apps.googleusercontent.com";
        googleOptions.ClientSecret = "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";
        googleOptions.Scope.Add("profile");
        googleOptions.ClaimActions.MapJsonKey("urn:google:profile", "link");
        googleOptions.ClaimActions.MapJsonKey("urn:google:image", "picture");
        googleOptions.Events.OnCreatingTicket = context =>
        {
            string picture = context.User.GetProperty("picture").GetString();

            context.Identity.AddClaim(new System.Security.Claims.Claim("Picture", picture));

            return Task.CompletedTask;
        };
        googleOptions.Events.OnRemoteFailure = (context) =>
        {
            context.HandleResponse();
            return context.Response.WriteAsync(
            "<script>window.close();</script>");
        };
    })
    .AddFacebook(facebookOptions =>
    {
        facebookOptions.AppId = "5413106098727642";
        facebookOptions.AppSecret = "e424db99568d737f0931dec73873dcb5";
        facebookOptions.Events.OnRemoteFailure = (context) =>
        {
            context.HandleResponse();
            return context.Response.WriteAsync(
            "<script>window.close();</script>");
        };
    });


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Help2Help API", Version = "v1" });
});
#endregion

var app = builder.Build();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger(); //Agregar " /swagger/index.html " al URL para acceder a la documentación
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Help2Help API");
});
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
