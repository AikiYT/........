using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.System;

namespace CitasMedicasApp.Persistance.Repositories.System
{
    public class StatusRepositorio : BaseRepository<StatusRepositorio>, IStatusRepositorio
    {
        public StatusRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(IStatusRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<IStatusRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IStatusRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(IStatusRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(IStatusRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(IStatusRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<IStatusRepositorio>> IStatusRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

