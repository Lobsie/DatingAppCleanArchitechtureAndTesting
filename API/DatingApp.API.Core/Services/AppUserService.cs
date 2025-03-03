using DatingApp.API.Core.Dtos;
using DatingApp.API.Core.Entities;
using DatingApp.API.Core.Interfaces.Mapping;
using DatingApp.API.Core.Interfaces.Repositories;
using DatingApp.API.Core.Interfaces.Repositories.Base;
using DatingApp.API.Core.Interfaces.Services;
using DatingApp.API.Core.Mapping.Base;
using DatingApp.API.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Services
{
    public class AppUserService(IAppUserRepository repository, IMapFromAppUserToAppUserDto mapper) 
        : BaseService<AppUserDto, AppUser>(repository, mapper), IAppUserService
    {
    }
}
