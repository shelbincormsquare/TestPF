using CupCakeWpf.UI.Models;
using System.Collections.Generic;

namespace CupCakeWpf.UI.Services.Interfaces
{
    public interface IItemService
    {
        List<Item> ToList();
        Item Single(int id);
        void Delete(int id);
        void Create(Item item);
        void Update(Item item);
    }
}
