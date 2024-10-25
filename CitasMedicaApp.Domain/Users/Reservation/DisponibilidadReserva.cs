using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities.Reservation
{
    public sealed class DisponibilidadReserva : BaseEntity
    {
        [Key]
        public int IdDoctor { get; set; }
        public DateTime FechaDisponible { get; set; }
        public string? HorasDisponibles { get; set; } 

        // Relación con Doctor
        public Doctors Doctor { get; set; }
    }
}
