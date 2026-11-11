
using Microsoft.EntityFrameworkCore;
using ApiProductosLINQ.Data;
using ApiProductosLINQ.Repositories;
using ApiProductosLINQ.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Registrar controladores y configurar JSON
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler =
            ReferenceHandler.IgnoreCycles;
    });

// Configurar Entity Framework Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ConexionSQL")));

// Registrar Repository
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();

// Registrar Service
builder.Services.AddScoped<IProductoService, ProductoService>();

// Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
