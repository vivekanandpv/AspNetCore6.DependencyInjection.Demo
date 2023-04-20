using AspNetCore6.DependencyInjection.Demo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<Person>();
builder.Services.AddScoped<Car>();

var app = builder.Build();

app.MapControllers();

app.Run();