using Donut.Core.Interfaces.Repositories;
using Donut.Core.SharedKernel;
using Donut.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Donut.Infrastructure.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : AggregateRoot
    {
        protected readonly AppDbContext _dbContext;

        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> SingleAsync(int id)
        {
            return await _dbContext.Set<T>().SingleAsync(e => e.Id == id);
        }

        public async Task<List<T>> ToListAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            //_dbContext.Set<T>(entity).State = EntityState.Modified;
        }

        public async Task RemoveAsync(int id)
        {
            var entity = await _dbContext.Set<T>().SingleAsync(e => e.Id == id);
            _dbContext.Set<T>().Remove(entity);
        }

    }
}
