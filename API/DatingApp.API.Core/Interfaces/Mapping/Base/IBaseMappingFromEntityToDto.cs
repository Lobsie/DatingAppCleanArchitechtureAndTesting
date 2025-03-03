using DatingApp.API.Core.Dtos.Base;
using DatingApp.API.Core.Entities.Base;

namespace DatingApp.API.Core.Interfaces.Mapping.Base
{
    public interface IBaseMappingFromEntityToDto<TDto, TEntity>
        where TDto : BaseDto
        where TEntity : EntityBase
    {
        TDto EntityMappedToDto(TEntity entityBase);
        IEnumerable<TDto> MapMultipleEntitiesToDtos(IEnumerable<TEntity> entities);
    }
}