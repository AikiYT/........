using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Configuration;
using CitasMedicasApp.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using CitasMedicasIOC.Dependencies.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddDbContext<CitaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CitasMedicasDb")));

// el registro de cada una de las dependencias repositorios de configuracion //

builder.Services.AddConfigurationDependency();




builder.Services.AddScoped<IDoctorRepositorio, DoctorRepositorio>();
builder.Services.AddScoped<ICitaRepositorio, CitaRepositorio>();
builder.Services.AddScoped<IPatientsRepositorio, PatientsRepositorio>();




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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


