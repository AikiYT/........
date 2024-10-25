using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Medical;
using CitasMedicasApp.Persistance.Interface.System;

namespace CitasMedicasApp.Persistance.Repositories.System
{
    public class NotificationsRepositorio : BaseRepository<NotificationsRepositorio>, INotificationsRepositorio
    {
        public NotificationsRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(INotificationsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<INotificationsRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<INotificationsRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(INotificationsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(INotificationsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(INotificationsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<INotificationsRepositorio>> INotificationsRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
