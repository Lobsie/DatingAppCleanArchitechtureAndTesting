using DatingApp.API.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Interfaces.Services.Base
{
    public interface IBaseService<TDto, TEntity>
        where TDto : BaseDto
    {
        Task<TDto> GetByIdAsync(int id);
        Task<IEnumerable<TDto>> GetAllAsync();
    }
}
