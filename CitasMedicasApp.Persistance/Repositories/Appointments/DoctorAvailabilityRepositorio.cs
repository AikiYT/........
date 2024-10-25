using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Appointments;

namespace CitasMedicasApp.Persistance.Repositories.Appointments
{

    public class DoctorAvailabilityRepositorio : BaseRepository<DoctorAvailabilityRepositorio>, IDoctorAvailabilityRepositorio
    {
        private readonly CitaContext _citaConext;

        public DoctorAvailabilityRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(IDoctorAvailabilityRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<IDoctorAvailabilityRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IAppointmentsRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(IDoctorAvailabilityRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(IDoctorAvailabilityRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(IDoctorAvailabilityRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<IAppointmentsRepositorio>> IDoctorAvailabilityRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}


    