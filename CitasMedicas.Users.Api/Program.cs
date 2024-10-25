using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Medical;
using CitasMedicasApp.Persistance.Interface.System;
using CitasMedicasApp.Persistance.Repositories.Medical;
using CitasMedicasApp.Persistance.Repositories.System;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CitaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CitasMedicasDb")));

// el registro de cada una de las dependencias repositorios de configuracion //

builder.Services.AddScoped<INotificationsRepositorio, NotificationsRepositorio>();
builder.Services.AddScoped<IRolsRepositorio, RolsRepositorio>();
builder.Services.AddScoped<IStatusRepositorio, StatusRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();





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
