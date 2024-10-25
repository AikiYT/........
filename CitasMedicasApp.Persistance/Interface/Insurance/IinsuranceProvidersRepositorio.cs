using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.Insurance 
{
      public interface IinsuranceProvidersRepositorio : IBaseRepository<IinsuranceProvidersRepositorio>
{
    Task<OperationRessult> Add(IinsuranceProvidersRepositorio entity);
    Task<OperationRessult> Update(IinsuranceProvidersRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IinsuranceProvidersRepositorio> GetById(int id);
    Task<IEnumerable<IinsuranceProvidersRepositorio>> GetAll();


}
}