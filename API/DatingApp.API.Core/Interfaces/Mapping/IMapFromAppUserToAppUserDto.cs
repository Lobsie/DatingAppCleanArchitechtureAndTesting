using DatingApp.API.Core.Dtos;
using DatingApp.API.Core.Entities;
using DatingApp.API.Core.Interfaces.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Interfaces.Mapping
{
    public interface IMapFromAppUserToAppUserDto : IBaseMappingFromEntityToDto<AppUserDto, AppUser>
    {
    }
}
