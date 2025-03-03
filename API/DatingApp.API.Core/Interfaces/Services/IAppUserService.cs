using DatingApp.API.Core.Dtos;
using DatingApp.API.Core.Entities;
using DatingApp.API.Core.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Interfaces.Services
{
    public interface IAppUserService : IBaseService<AppUserDto, AppUser>
    {
    }
}
