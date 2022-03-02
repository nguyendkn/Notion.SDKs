using NotionCore;
using NotionCore.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

var appSettings = new AppSettings();
configuration.Bind(appSettings);

services.AddEndpointsApiExplorer();
services.AddControllers();
services.AddSwaggerGen();
services.NotionClient(appSettings.NotionOptions);

var app = builder.Build();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.Run();