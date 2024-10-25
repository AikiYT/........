using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.System;

namespace CitasMedicasApp.Persistance.Repositories.System
{
    public class UsuarioRepositorio : BaseRepository<UsuarioRepositorio>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(IUsuarioRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<IUsuarioRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IUsuarioRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(IUsuarioRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(IUsuarioRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(IUsuarioRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<IUsuarioRepositorio>> IUsuarioRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}