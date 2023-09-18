using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using WebApplication2.DBContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v0.0.1",
        Title = "SwaggerBase Api",
        Description = "A simple example ASP.NET Core Web API. For Reference please click [getting-started-with-swashbuckle](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio) or [swagger.io/docs/](https://swagger.io/docs/)",
        TermsOfService = new Uri("https://example.com/termsIfApplicable")
    });
});
builder.Services.AddControllers();

var app = builder.Build();

// Configure connection string
Common.connectionstring = app.Configuration.GetConnectionString("main");

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API");
    options.RoutePrefix = string.Empty;
    options.DocumentTitle = "My Swagger";
});

app.Run();
