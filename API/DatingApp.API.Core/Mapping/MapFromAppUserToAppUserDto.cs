using DatingApp.API.Core.Dtos;
using DatingApp.API.Core.Dtos.Base;
using DatingApp.API.Core.Entities;
using DatingApp.API.Core.Entities.Base;
using DatingApp.API.Core.Interfaces.Mapping;
using DatingApp.API.Core.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Mapping
{
    public class MapFromAppUserToAppUserDto : BaseMappingFromEntityToDto<AppUserDto, AppUser>, IMapFromAppUserToAppUserDto
    {
        public override AppUserDto EntityMappedToDto(AppUser entityBase)
        {
            AppUserDto returnDto = new()
            {
                Id = entityBase.Id,
                UserName = entityBase.UserName
            };

            return returnDto;
        }

        public override IEnumerable<AppUserDto> MapMultipleEntitiesToDtos(IEnumerable<AppUser> entities)
        {
            var dtos = entities.Select(a => new AppUserDto
            {
                Id = a.Id,
                UserName = a.UserName
            });

            if (dtos == null)
                return new List<AppUserDto>();

            return dtos;
        }
    }
}
