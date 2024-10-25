using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicaApp.Domain.Users;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Configuration;
using CitasMedicasApp.Persistance.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicasApp.Persistance.Repositories
{
    public sealed class DoctorRepositorio : BaseRepository<Doctors>, IDoctorRepositorio
    {
        private readonly CitaContext _citaContext;

        public DoctorRepositorio(CitaContext citaContext) : base(citaContext)
        {
            _citaContext = citaContext;
        }
        public async Task<OperationRessult> Add(Doctors entity)
        {
            return await Save(entity);
        }

        public async Task<OperationRessult> Delete(int id)
        {
            var doctor = await GetEntityBy(id);
            if (doctor.Success && doctor.Data is Doctors entity)
            {
                return await Remove(entity);
            }
            return new OperationRessult(false, "Doctor no encontrado.");
        }

        public async Task<OperationRessult> Exists(Expression<Func<Doctors, bool>> filter)
        {
            bool exists = await base.Exists(filter);
            return new OperationRessult(exists, exists ? "Doctor existe." : "Doctor no existe.");
        }

        public async Task<Doctors> GetById(int id)
        {
            var result = await GetEntityBy(id);
            return result.Data as Doctors;
        }

        public async Task<OperationRessult> Remove(Doctors entity)
        {
            return await base.Remove(entity);
        }

        public async Task<OperationRessult> Save(Doctors entity)
        {
            return await base.Save(entity);
        }

        public async Task<OperationRessult> Update(Doctors entity)
        {
            return await base.Update(entity);
        }

        Task<bool> IBaseRepository<Doctors>.Exists(Expression<Func<Doctors, bool>> filter)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Doctors>> IDoctorRepositorio.GetAll()
        {
            var result = await base.GetAll();
            return result.Data as List<Doctors>;
        }

        public Result<IEnumerable<Doctors>> GettAll()
        {
            try
            {
                // Aquí deberías obtener los datos de la base de datos o de otro lugar
                var doctors = new List<Doctors>
                {
                new Doctors { DoctorID = 1, LicenseNumber = "Dr. Smith" },
                new Doctors { DoctorID = 2, LicenseNumber = "Dr. Johnson" }
            };

                // Si se obtuvo correctamente la lista de doctores, devolvemos un resultado exitoso
                return new Result<IEnumerable<Doctors>>
                {
                    Success = true,
                    Data = doctors
                };
            }
            catch (Exception ex)
            {
                // Si ocurre un error, devolvemos un resultado fallido
                return new Result<IEnumerable<Doctors>>
                {
                    Success = false,
                    Message = $"Ocurrió un error al obtener los doctores: {ex.Message}"
                };
            }
        }
    }
}

