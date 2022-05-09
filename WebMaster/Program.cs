
using Serilog;
using DogManager;
using WebMaster.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
ConfigurationManager configuration = builder.Configuration;
//builder.Host.UseSerilog((ctx, lc) => lc
//    .WriteTo.Console()
//    .WriteTo.File(@"x:\logs\test.log"));
var dog = new Dogger();
builder.Services.AddSingleton<IDogger>(dog);
// builder.Services.AddScoped<IDogger, Dogger>();
WeatherForecastController.refcounter = 0;
var app = builder.Build();

IConfiguration conf = app.Configuration;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
