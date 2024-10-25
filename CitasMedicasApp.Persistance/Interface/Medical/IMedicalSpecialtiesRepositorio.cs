using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.Medical 
{
           public interface IMedicalSpecialtiesRepositorio : IBaseRepository<IMedicalSpecialtiesRepositorio>
{
    Task<OperationRessult> Add(IMedicalSpecialtiesRepositorio entity);
    Task<OperationRessult> Update(IMedicalSpecialtiesRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IMedicalSpecialtiesRepositorio> GetById(int id);
    Task<IEnumerable<IMedicalSpecialtiesRepositorio>> GetAll();


}
}