using locadora_de_carros.Application.Mappers;
using locadora_de_carros.Data;
using locadora_de_carros.Data.Repositories;
using locadora_de_carros.Data.Repositories.Abstractions;
using locadora_de_carros.Services;
using locadora_de_carros.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));

builder.Services.AddAutoMapper(typeof(DomainModelMappingProfile));

builder.Services.AddScoped<ICarrosRepository, CarroRepository>();
builder.Services.AddScoped<ICarroService, CarroService>();

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
