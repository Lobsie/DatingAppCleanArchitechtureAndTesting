using DatingApp.API.Core.Dtos.Base;
using DatingApp.API.Core.Entities.Base;
using DatingApp.API.Core.Interfaces.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Mapping.Base
{
    public class BaseMappingFromEntityToDto<TDto, TEntity> : IBaseMappingFromEntityToDto<TDto, TEntity> where TDto : BaseDto
        where TEntity : EntityBase
    {
        public virtual TDto EntityMappedToDto(TEntity entityBase)
        {
            BaseDto returnDto = new()
            {
                Id = entityBase.Id
            };

            return (TDto)returnDto;
        }

        public virtual IEnumerable<TDto> MapMultipleEntitiesToDtos(IEnumerable<TEntity> entities)
        {
            var dtos = entities.Select(a => new BaseDto
            {
                Id = a.Id
            });

            if (dtos == null)
                return new List<TDto>();

            return (IEnumerable<TDto>)dtos;
        }
    }
}
