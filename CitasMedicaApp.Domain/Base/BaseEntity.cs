using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CitasMedicaApp.Domain.Base
{
    public abstract class BaseEntity
    {
        // Identificador único de la entidad
       

        // Fecha de creación
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Fecha de la última actualización
        public DateTime? UpdatedAt { get; set; }

        // Indica si la entidad está eliminada lógicamente (soft delete)
        public bool IsDeleted { get; set; } = false;

        // Método que se puede sobrescribir en entidades derivadas
       

        // Método que actualiza la fecha de modificación
       
    }
}
 





