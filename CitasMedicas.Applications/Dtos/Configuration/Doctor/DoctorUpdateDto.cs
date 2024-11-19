using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas.Applications.Dtos.Configuration.Doctor
{
    public class DoctorUpdateDto : DoctorBaseDto
    {
        public int DoctorID { get; set; }

        public int SpecialtyID { get; set; }

        public string? LicenseNumber { get; set; }

        public string? PhoneNumber { get; set; }

        public int YearsOfExperience { get; set; }

        public string? Education { get; set; }

        public string? Bio { get; set; }

        public decimal ConsultationFee { get; set; }

        public string? ClinicAddress { get; set; }

        public int AvailabilityModeId { get; set; }

        public DateTime licenseExpirationDate { get; set; }

        

       

    }
}
