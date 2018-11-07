using Donut.Core.Entites;
using System.Data.Entity;

namespace Donut.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DonutDb")
        {
         
        }
        public DbSet<Item> Items { get; set; }
    }
}
