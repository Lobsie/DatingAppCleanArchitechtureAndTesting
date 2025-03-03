using DatingApp.API.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Interfaces.Repositories.Base
{
    public interface IBaseRepository<TEntity> 
        where TEntity : EntityBase
    {
        Task<TEntity> GetByIdAsync(int id);
        IQueryable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
