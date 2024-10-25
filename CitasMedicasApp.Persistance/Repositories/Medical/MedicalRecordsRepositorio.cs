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

namespace CitasMedicasApp.Persistance.Repositories.Medical
{
    public class MedicalRecordsRepositorio : BaseRepository<MedicalRecordsRepositorio>, IMedicalRecordsRepositorio
    {
        public MedicalRecordsRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(IMedicalRecordsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<IMedicalRecordsRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IMedicalRecordsRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(IMedicalRecordsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(IMedicalRecordsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(IMedicalRecordsRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<IMedicalRecordsRepositorio>> IMedicalRecordsRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
