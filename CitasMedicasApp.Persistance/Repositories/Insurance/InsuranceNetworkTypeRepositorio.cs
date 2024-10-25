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
using CitasMedicasApp.Persistance.Interface.Insurance;

namespace CitasMedicasApp.Persistance.Repositories.Insurance 
{ 
   public class InsuranceNetworkTypeRepositorio : BaseRepository<InsuranceNetworkTypeRepositorio>, IinsuranceNetworkTypeRepositorio
{


    private readonly CitaContext _citaConext;

    public InsuranceNetworkTypeRepositorio(CitaContext citaContext) : base(citaContext)
    {
    }

    public Task<OperationRessult> Add(IinsuranceNetworkTypeRepositorio entity)
    {
        throw new NotImplementedException();
    }

    public Task<OperationRessult> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Exists(Expression<Func<IinsuranceNetworkTypeRepositorio, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public Task<IinsuranceNetworkTypeRepositorio> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<OperationRessult> Remove(IinsuranceNetworkTypeRepositorio entity)
    {
        throw new NotImplementedException();
    }

    public Task<OperationRessult> Save(IinsuranceNetworkTypeRepositorio entity)
    {
        throw new NotImplementedException();
    }

    public Task<OperationRessult> Update(IinsuranceNetworkTypeRepositorio entity)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<IinsuranceNetworkTypeRepositorio>> IinsuranceNetworkTypeRepositorio.GetAll()
    {
        throw new NotImplementedException();
    }
  
}
}

    