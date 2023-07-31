using Microsoft.EntityFrameworkCore;
using RndTech.SalariesMonitoring.Database;

var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("SALARIESMONITORINGAPP_DATABASE_CONNECTION_STRING");
builder.Services.AddDbContextFactory<SalariesMonitoringDbContext>(optionsBuilder =>
	optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

var port = Environment.GetEnvironmentVariable("SALARIESMONITORINGAPP_PORT") ?? "29600";
app.Urls.Add($"http://*:{port}");

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");

app.Run();