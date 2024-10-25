﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Reservation
{
    public sealed class SolicitudReserva : BaseEntity
    {
        [Key]
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string? Estado { get; set; } // Pendiente, Aprobada, Rechazada
        public string? Motivo { get; set; } 

        // Relaciones
        public Patients Paciente { get; set; }
        public Doctors Doctor { get; set; }
    }
}
