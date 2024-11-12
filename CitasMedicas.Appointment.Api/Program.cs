using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Appointments;
using CitasMedicasApp.Persistance.Interface.Configuration;
using CitasMedicasApp.Persistance.Interface.Insurance;
using CitasMedicasApp.Persistance.Repositories;
using CitasMedicasApp.Persistance.Repositories.Appointments;
using CitasMedicasApp.Persistance.Repositories.Insurance;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.




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

app.Run(); //


