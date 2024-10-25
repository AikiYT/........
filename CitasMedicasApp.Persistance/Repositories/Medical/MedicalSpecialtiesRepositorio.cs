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
    public class MedicalSpecialtiesRepositorio : BaseRepository<MedicalSpecialtiesRepositorio>, IMedicalSpecialtiesRepositorio
    {
        public MedicalSpecialtiesRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Add(IMedicalSpecialtiesRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<IMedicalSpecialtiesRepositorio, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IMedicalSpecialtiesRepositorio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Remove(IMedicalSpecialtiesRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(IMedicalSpecialtiesRepositorio entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(IMedicalSpecialtiesRepositorio entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<IMedicalSpecialtiesRepositorio>> IMedicalSpecialtiesRepositorio.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
