using hoangtiendung.Ecommerce.API.ApplicationBuilder;
using hoangtiendung.Ecommerce.API.ServiceCollection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceRegisters(builder.Configuration);
builder.Services.AddDIRegisters();

var app = builder.Build();

app.UseApplicationBuilder(app.Environment.IsDevelopment());

app.MapControllers();

app.Run();
