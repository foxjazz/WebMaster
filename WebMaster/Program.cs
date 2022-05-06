
using Serilog;
using DogManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Host.UseSerilog((ctx, lc) => lc
//    .WriteTo.Console()
//    .WriteTo.File(@"x:\logs\test.log"));
var dog = new Dogger();
builder.Services.AddSingleton<IDogger>(_ => new Dogger());
builder.Services.AddScoped<IDogger, Dogger>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
