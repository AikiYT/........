using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Interface.Appointments;

namespace CitasMedicasApp.Persistance.Interface.Insurance  
{
       public interface IinsuranceNetworkTypeRepositorio : IBaseRepository<IinsuranceNetworkTypeRepositorio>
{
    Task<OperationRessult> Add(IinsuranceNetworkTypeRepositorio entity);
    Task<OperationRessult> Update(IinsuranceNetworkTypeRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IinsuranceNetworkTypeRepositorio> GetById(int id);
    Task<IEnumerable<IinsuranceNetworkTypeRepositorio>> GetAll();


}
}