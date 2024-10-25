using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Entities.Appointments;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Appointments;

namespace CitasMedicasApp.Persistance.Repositories.Appointments
{
    public class AppointmentsRepositorio : BaseRepository<AppointmentsRepositorio>, IAppointmentsRepositorio
    {
        private readonly CitaContext _citaConext;

        public AppointmentsRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(IAppointmentsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<IAppointmentsRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IAppointmentsRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(IAppointmentsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(IAppointmentsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(IAppointmentsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<IAppointmentsRepositorio>> IAppointmentsRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

       