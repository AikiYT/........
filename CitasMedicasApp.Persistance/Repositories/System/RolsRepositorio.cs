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
   public class RolsRepositorio : BaseRepository<RolsRepositorio>, IRolsRepositorio
{
    public RolsRepositorio(CitaContext citaContext) : base(citaContext)
    {
    }

    public Task<OperationRessult> Add(IRolsRepositorio entity)
    {
        throw new NotImplementedException();
    }

    public Task<OperationRessult> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Exists(Expression<Func<IRolsRepositorio, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public Task<IRolsRepositorio> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<OperationRessult> Remove(IRolsRepositorio entity)
    {
        throw new NotImplementedException();
    }

    public Task<OperationRessult> Save(IRolsRepositorio entity)
    {
        throw new NotImplementedException();
    }

    public Task<OperationRessult> Update(IRolsRepositorio entity)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<IRolsRepositorio>> IRolsRepositorio.GetAll()
    {
        throw new NotImplementedException();
    }
}
}