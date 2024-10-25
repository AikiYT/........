using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicasApp.Persistance.Result
{
    public class Result<T>
    {
        public bool Success { get; set; }       // Si la operación fue exitosa
        public string Message { get; set; }     // Un mensaje opcional (de error o éxito)
        public T Data { get; set; }     //        // Los datos devueltos (en este caso, una lista de doctores u otros objetos)
    }
}
//