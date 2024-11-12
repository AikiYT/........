using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas.Applications.Dtos.Configuration.Doctor
{
   public class DoctorBaseDto 
    {
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsActive { get; set; }

        public DateTime FechaCambio { get; set; }

        public int UsuarioCambio { get; set; }

    }
}
