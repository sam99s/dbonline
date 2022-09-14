using Microsoft.EntityFrameworkCore;
using dbonline;
using Microsoft.AspNetCore.Mvc;
using dbonline.Interfaces;
using dbonline.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connect DB
builder.Services.AddSqlServer<DbonlineContext>(builder.Configuration.GetConnectionString("cnDbonline"));
builder.Services.AddScoped<IBatallasService, BatallasService>();
builder.Services.AddScoped<IImagenService, ImagenService>();
builder.Services.AddScoped<IPersonajesService, PersonajesService>();
builder.Services.AddScoped<ITransformacionesService, TransformacionesService>();
builder.Services.AddScoped<IRazaService, RazasService>();
builder.Services.AddScoped<ISagasService, SagasService>();
builder.Services.AddScoped<ISeriesService, SeriesService>();
builder.Services.AddScoped<IUniversosService, UniversosService>();


var app = builder.Build();

app.MapGet("/dbconexion", async ([FromServices] DbonlineContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Connect DB OK");
});

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
