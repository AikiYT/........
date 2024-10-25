using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.Medical
{
        public interface IMedicalRecordsRepositorio : IBaseRepository<IMedicalRecordsRepositorio>
{
    Task<OperationRessult> Add(IMedicalRecordsRepositorio entity);
    Task<OperationRessult> Update(IMedicalRecordsRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IMedicalRecordsRepositorio> GetById(int id);
    Task<IEnumerable<IMedicalRecordsRepositorio>> GetAll();


}
}