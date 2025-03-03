using DatingApp.API.Core.Entities;
using DatingApp.API.Core.Interfaces.Repositories;
using DatingApp.API.Infrastructure.Data;
using DatingApp.API.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Infrastructure.Repositories
{
    public class UserRepository(ApplicationDbContext dbContext) : BaseRepository<AppUser>(dbContext), IAppUserRepository
    {
    }
}
