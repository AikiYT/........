using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Entities;
using CitasMedicas.Applications.Base;
using CitasMedicas.Applications.Contracts;
using CitasMedicas.Applications.Dtos.Configuration.Doctor;
using CitasMedicas.Applications.Responses.Configuration.Doctor;
using CitasMedicasApp.Persistance.Interface.Configuration;
using Microsoft.Extensions.Logging;

namespace CitasMedicas.Applications.Services.Configuration
{
    public class DoctorService : IDoctorService
    {
      
        private readonly IDoctorRepositorio _doctorRepositorio;
        private readonly ILogger<DoctorService> _logger;

        public DoctorService(IDoctorRepositorio doctorRepositorio, ILogger<DoctorService> logger)  /// COLOR LA INTERFAZ DE NOTIFICACIONES
        {
            if (doctorRepositorio is null)
            {
                throw new ArgumentNullException(nameof(doctorRepositorio));
            }

            this._doctorRepositorio = doctorRepositorio;
            this._logger = logger;
        }
        public async Task<DoctorResponse> GetAll()
        {
            DoctorResponse doctorResponse = new DoctorResponse();
            try
            {
                var result = await _doctorRepositorio.GetAll();
                // acuerdate de llenar como el SaveAsync todo esto de las variables de doctors que quiera mostrar en la api
                //doctorResponse.Model = result.Data;
              //  List<Doctors> doctors = (List<Doctors>)result.Data;
               
            }
            catch (Exception ex)
            {
                doctorResponse.IsSuccess = false;
                doctorResponse.Message = "Error obteniendo los doctores ";
                _logger.LogError(doctorResponse.Message, ex.ToString);
            }
            
            return doctorResponse;
        }

        public async Task<DoctorResponse> GetById(int Id)
        {
            DoctorResponse doctorResponse = new DoctorResponse();

            try
            {
                var result = await _doctorRepositorio.GetEntityBy(Id);
                // acuerdate de llenar todo esto como el saveAsync
            }
            catch (Exception ex) 
            {
                doctorResponse.IsSuccess = false;
                doctorResponse.Message = "Error obteniendo los doctores ";
                _logger.LogError(doctorResponse.Message, ex.ToString);

            }
            return doctorResponse;
        }

        public Task<DoctorSaveDto> SaveAsync(DoctorSaveDto dto)
        {
            throw new NotImplementedException();
            /*  DoctorResponse doctorResponse = new DoctorResponse();


              try
              {
                  Doctors doctor = new Doctors();

                  doctor.YearsOfExperience = dto.YearsOfExperience;
                  doctor.Education = dto.Education;
                  doctor.LicenseNumber = dto.LicenseNumber;
                  doctor.UpdatedAt = dto.UpdatedAt;
                  var result = _doctorRepositorio.Save(doctor);
              }
              // acuerdate de llenar todo esto

              catch (Exception ex)
              {
                  doctorResponse.IsSuccess = false;
                  doctorResponse.Message = "Error obteniendo los doctores ";
                  _logger.LogError(doctorResponse.Message, ex.ToString);

              }

              return doctorResponse; */
        }

        public Task<DoctorResponse> UpdateAsync(DoctorUpdateDto dto)
        {
            throw new NotImplementedException();
            /*   DoctorResponse doctorResponse = new DoctorResponse();


                try
                {
                    Doctors doctor = (Doctors)resultEntity.Data

                    doctor.YearsOfExperience = dto.YearsOfExperience;
                    doctor.Education = dto.Education;
                    doctor.LicenseNumber = dto.LicenseNumber;
                    doctor.UpdatedAt = dto.UpdatedAt;
                    var result = _doctorRepositorio.Update(doctor);
                }
                // acuerdate de llenar todo esto

                catch (Exception ex)
                {
                    doctorResponse.IsSuccess = false;
                    doctorResponse.Message = "Error obteniendo los doctores ";
                    _logger.LogError(doctorResponse.Message, ex.ToString);

                }

                return doctorResponse; */
        }
    }
}
