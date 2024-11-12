using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas.Applications.Core
{
    public abstract class BaseResponse
    {
        protected BaseResponse() 
        { 
            this.IsSuccess = true;
        }
        public bool IsSuccess { get; set; }

        public string? Message { get; set; }
    }
}
