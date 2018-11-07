using Donut.Core.SharedKernel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Donut.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : AggregateRoot
    {
        Task<T> SingleAsync(int id);
        Task<List<T>> ToListAsync();
        void Add(T entity);
        void Update(T entity);
        Task RemoveAsync(int id);
    }
}
