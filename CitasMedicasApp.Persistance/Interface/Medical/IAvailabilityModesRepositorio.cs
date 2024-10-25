using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.Medical 
{
     public interface IAvailabilityModesRepositorio : IBaseRepository<IAvailabilityModesRepositorio>
{
    Task<OperationRessult> Add(IAvailabilityModesRepositorio entity);
    Task<OperationRessult> Update(IAvailabilityModesRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IAvailabilityModesRepositorio> GetById(int id);
    Task<IEnumerable<IAvailabilityModesRepositorio>> GetAll();


}
}