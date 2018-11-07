using Donut.Core.Entites;
using Donut.Core.Interfaces.Repositories;
using Donut.Infrastructure.Persistence;

namespace Donut.Infrastructure.Repositories
{
    public class ItemRepository : EfRepository<Item>, IItemRepository
    {
        public ItemRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
