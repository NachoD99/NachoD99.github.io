global using Help2Help.Server.Services.EventService;
using Help2Help.Server.Services.NotificationService;
using Help2Help.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Help2Help API", Version = "v1" });
});


builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer("Server=tcp:help2help.database.windows.net,1433;Initial Catalog=Help2Help;Persist Security Info=False;User ID=help2help;Password=h2hProject.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
});
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<INotificationService, NotificationService>();

var app = builder.Build();

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Help2Help API");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
