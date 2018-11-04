using System;
using System.Collections.Generic;
using System.Linq;

namespace CupCakeWpf.UI.Services
{
    public class ItemRepository : IItemRepository
    {
        public ItemRepository()
        {
            _items = new List<Item>() {
                new Item (){Description = "ss", IsActive = true, Name="sas", Price=122, StockDate= DateTime.Now, Id =1},
                new Item (){Description = "dsadasd", IsActive = true, Name="sa1111sasa", Price=54, StockDate= DateTime.Now, Id =2},
                new Item (){Description = "sdsads", IsActive = true, Name="sa212s", Price=1, StockDate= DateTime.Now, Id =3},
            };
        }

        private List<Item> _items { get; set; }

        public void Add(Item item)
        {

        }

        public List<Item> GetAllItems()
        {
            return _items;
        }

        public Item GetItem(int id)
        {
            return _items.Single(s => s.Id == id);
        }

        public void Update(Item item)
        {
            throw new NotImplementedException();
        }
    }

    public interface IItemRepository
    {
        List<Item> GetAllItems();
        Item GetItem(int id);
        void Add(Item item);
        void Update(Item item);
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime StockDate { get; set; }
    }
}
