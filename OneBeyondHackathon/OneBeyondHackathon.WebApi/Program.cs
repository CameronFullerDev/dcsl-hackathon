using OneBeyondHackathon.Logic.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add a service to DI
builder.Services.AddSingleton<IQuoteService, QuoteService>();
builder.Services.AddSingleton<IQuoteService, QuoteService>();
const string logicAppUrl = "https://prod-183.westeurope.logic.azure.com:443/workflows/8731ffce505942aeb1b01c9115fff5e5/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=ZUGW60TGOJhHgj9lk787VidjN3o0li__WFDxB0C7ZDI";
builder.Services.AddHttpClient<ILogicAppService, LogicAppService>(client => client.BaseAddress = new Uri(logicAppUrl));
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
