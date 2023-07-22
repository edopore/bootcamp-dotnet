using Microsoft.EntityFrameworkCore;
using Discoteque.Data;
using Discoteque.Business.Service;
using Discoteque.Business.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); //Controlador
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); //Endpoints
builder.Services.AddSwaggerGen(); //Swagger

builder.Services.AddDbContext<DiscotequeContext>( //Base de Datos
    opt => opt.UseInMemoryDatabase("Discoteque")
);

builder.Services.AddScoped<IArtistService,ArtistService>();

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
