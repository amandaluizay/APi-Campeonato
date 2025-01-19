using Campeonato.CL.Domain.Interfaces.Entities;
using Microsoft.EntityFrameworkCore;

namespace Campeonato.CL.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity>
              where TEntity : class, IEntity
    {
        DbSet<TEntity> Entities { get; }

        Task<List<TEntity>> GetAsync();

        Task<TEntity?> GetByIdAsync(Guid id);

        Task<TEntity> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> DeleteAsync(Guid id);

        Task<bool> AnyAsync(Guid id);
    }
}
