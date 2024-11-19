using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicas.Applications.Core;

namespace CitasMedicas.Applications.Responses.Configuration.Doctor
{
    public class DoctorResponse : BaseResponse 
    {
       public dynamic? Model { get; set; }

        public dynamic? Data { get; set; }

        public int DoctorID { get; set; }

        public string? YearsOfExperience {  get; set; }

        public string? Education { get; set; }
    }
}
