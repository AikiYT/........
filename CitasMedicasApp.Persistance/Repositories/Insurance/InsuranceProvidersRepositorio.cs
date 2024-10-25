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

namespace CitasMedicasApp.Persistance.Repositories.Insurance
{
    public class InsuranceProvidersRepositorio : BaseRepository<InsuranceProvidersRepositorio>, IinsuranceProvidersRepositorio
    {
        public InsuranceProvidersRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(IinsuranceProvidersRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<IinsuranceProvidersRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IinsuranceProvidersRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(IinsuranceProvidersRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(IinsuranceProvidersRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(IinsuranceProvidersRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<IinsuranceProvidersRepositorio>> IinsuranceProvidersRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

    