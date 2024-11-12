using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas.Applications.Base
{
    public interface IBaseService<TResponse, TSaveDto, TUpdateDto>
    {
         Task<TSaveDto> SaveAsync(TSaveDto dto); 
        
         Task<TResponse> UpdateAsync(TUpdateDto dto);

        Task<TResponse> GetAll();

        Task<TResponse> GetById(int Id);

        
    }
}
