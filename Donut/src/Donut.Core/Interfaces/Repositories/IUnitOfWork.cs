using System.Threading.Tasks;

namespace Donut.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IItemRepository Items { get; }
        Task CompleteAsync(int userId);
    }
}
