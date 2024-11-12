using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicas.Applications.Core;

namespace CitasMedicas.Applications.Responses.Configuration.Doctor
{
     public sealed class SaveResponse : BaseResponse
    {
        public int DoctorID { get; set; }

        
    }
}
