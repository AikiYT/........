using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicas.Applications.Base;
using CitasMedicas.Applications.Dtos.Configuration.Doctor;
using CitasMedicas.Applications.Dtos.Configuration.Patients;
using CitasMedicas.Applications.Responses.Configuration.Doctor;
using CitasMedicas.Applications.Responses.Configuration.Patients;

namespace CitasMedicas.Applications.Contracts
{
    public interface IPatientsService : IBaseService<PatientsResponse, PatientsSaveDto, PatientsUpdateDto>
    {
    }
}
