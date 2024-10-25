using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.System 
{
             public interface IRolsRepositorio : IBaseRepository<IRolsRepositorio>
{
    Task<OperationRessult> Add(IRolsRepositorio entity);
    Task<OperationRessult> Update(IRolsRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IRolsRepositorio> GetById(int id);
    Task<IEnumerable<IRolsRepositorio>> GetAll();


}
}