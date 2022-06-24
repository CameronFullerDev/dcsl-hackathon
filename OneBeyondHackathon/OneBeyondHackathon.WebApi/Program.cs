using Microsoft.EntityFrameworkCore;
using OneBeyondHackathon.Logic.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("WebApiDatabase");
builder.Services.AddDbContext<OneBeyondHackathon.Logic.Storage.DatabaseContext>(x => x.UseSqlServer(connectionString));

// Add a service to DI
builder.Services.AddTransient<IQuoteService, QuoteService>();
builder.Services.AddTransient<IImageService, ImageService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
