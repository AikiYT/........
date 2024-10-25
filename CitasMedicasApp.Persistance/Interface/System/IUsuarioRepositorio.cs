using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.System 
{
                public interface IUsuarioRepositorio : IBaseRepository<IUsuarioRepositorio>
{
    Task<OperationRessult> Add(IUsuarioRepositorio entity);
    Task<OperationRessult> Update(IUsuarioRepositorio entity);
    Task<OperationRessult> Delete(int id);
    Task<IUsuarioRepositorio> GetById(int id);
    Task<IEnumerable<IUsuarioRepositorio>> GetAll();


}
}
