using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.System 
{
             public interface INotificationsRepositorio : IBaseRepository<INotificationsRepositorio>
{
    Task<OperationRessult> Add(INotificationsRepositorio entity);
    Task<OperationRessult> Update(INotificationsRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<INotificationsRepositorio> GetById(int id);
    Task<IEnumerable<INotificationsRepositorio>> GetAll();


}
}
