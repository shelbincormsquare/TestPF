using Donut.Core.Interfaces.Repositories;
using Donut.Infrastructure.Persistence;
using System.Threading.Tasks;

namespace Donut.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        public IItemRepository Items { get; private set; }
        public UnitOfWork(AppDbContext context)
        {
            _dbContext = context;
            Items = new ItemRepository(context);
        }

        public async Task CompleteAsync(int userId)
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
