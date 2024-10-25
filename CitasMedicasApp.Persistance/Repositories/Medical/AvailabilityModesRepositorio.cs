using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Insurance;
using CitasMedicasApp.Persistance.Interface.Medical;

namespace CitasMedicasApp.Persistance.Repositories.Medical
{
    public class AvailabilityModesRepositorio : BaseRepository<AvailabilityModesRepositorio>, IAvailabilityModesRepositorio
    {
        public AvailabilityModesRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(IAvailabilityModesRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<IAvailabilityModesRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IAvailabilityModesRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(IAvailabilityModesRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(IAvailabilityModesRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(IAvailabilityModesRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<IAvailabilityModesRepositorio>> IAvailabilityModesRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

