using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.System 
{
             public interface IStatusRepositorio : IBaseRepository<IStatusRepositorio>
{
    Task<OperationRessult> Add(IStatusRepositorio entity);
    Task<OperationRessult> Update(IStatusRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IStatusRepositorio> GetById(int id);
    Task<IEnumerable<IStatusRepositorio>> GetAll();


}
}
