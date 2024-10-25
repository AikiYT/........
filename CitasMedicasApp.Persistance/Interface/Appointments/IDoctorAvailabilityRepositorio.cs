using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.Appointments  
{
   public interface IDoctorAvailabilityRepositorio : IBaseRepository<IDoctorAvailabilityRepositorio>
{
    Task<OperationRessult> Add(IDoctorAvailabilityRepositorio entity);
    Task<OperationRessult> Update(IDoctorAvailabilityRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IAppointmentsRepositorio> GetById(int id);
    Task<IEnumerable<IAppointmentsRepositorio>> GetAll();


}
}

