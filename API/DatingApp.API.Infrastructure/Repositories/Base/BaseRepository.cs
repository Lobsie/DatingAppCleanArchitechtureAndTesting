using DatingApp.API.Core.Entities.Base;
using DatingApp.API.Core.Interfaces.Repositories.Base;
using DatingApp.API.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Infrastructure.Repositories.Base
{
    public class BaseRepository<TEntity>(ApplicationDbContext dbContext) : IBaseRepository<TEntity> where TEntity : EntityBase
    {
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await GetAll().ToListAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().AsNoTracking();
        }
    }
}
