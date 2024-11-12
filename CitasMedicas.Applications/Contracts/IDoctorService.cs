using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicas.Applications.Base;
using CitasMedicas.Applications.Dtos.Configuration.Doctor;
using CitasMedicas.Applications.Responses.Configuration.Doctor;

namespace CitasMedicas.Applications.Contracts
{
    public interface IDoctorService : IBaseService<DoctorResponse, DoctorSaveDto, DoctorUpdateDto>
    {
    }
}
