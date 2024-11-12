
using CitasMedicasApp.Persistance.Interface.Configuration;
using CitasMedicasApp.Persistance.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CitasMedicasIOC.Dependencies.Configuration
{
    public static class ConfigurationDependency // esta clase es para hacer el registro de las dependencias de las apis
    {
        public static void AddConfigurationDependency( this IServiceCollection service)
        {
            service.AddScoped<IDoctorRepositorio, DoctorRepositorio>();
            service.AddScoped<ICitaRepositorio, CitaRepositorio>();
            service.AddScoped<IPatientsRepositorio, PatientsRepositorio>();
        }
    }
}

