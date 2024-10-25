using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Entities; 
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;

namespace CitasMedicasApp.Persistance.Interface.Appointments
{
    public interface IAppointmentsRepositorio : IBaseRepository<IAppointmentsRepositorio>
    {
        Task<OperationRessult> Add(IAppointmentsRepositorio entity);
        Task<OperationRessult> Update(IAppointmentsRepositorio  entity);
        Task<OperationRessult> Delete(int id);
        Task<IAppointmentsRepositorio> GetById(int id);
        Task<IEnumerable<IAppointmentsRepositorio>> GetAll();


    }
}
