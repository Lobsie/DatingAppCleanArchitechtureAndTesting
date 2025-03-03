using DatingApp.API.Core.Dtos.Base;
using DatingApp.API.Core.Entities.Base;
using DatingApp.API.Core.Interfaces.Mapping.Base;
using DatingApp.API.Core.Interfaces.Repositories.Base;
using DatingApp.API.Core.Interfaces.Services.Base;
using DatingApp.API.Core.Mapping;
using DatingApp.API.Core.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Services.Base
{
    public class BaseService<TResponseDto, TEntity>(IBaseRepository<TEntity> repository, IBaseMappingFromEntityToDto<TResponseDto, TEntity> mapper) 
        : IBaseService<TResponseDto, TEntity> 
        where TResponseDto : BaseDto
        where TEntity : EntityBase
    {
        public async Task<IEnumerable<TResponseDto>> GetAllAsync()
        {
            var entities = await repository.GetAllAsync();

            var dtos = mapper.MapMultipleEntitiesToDtos(entities);

            return dtos;
        }

        public async Task<TResponseDto> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync(id);

            var dto = mapper.EntityMappedToDto(entity);

            return (TResponseDto)dto;
        }
    }
}
