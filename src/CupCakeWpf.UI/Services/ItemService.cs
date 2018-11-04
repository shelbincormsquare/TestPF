using System;
using System.Collections.Generic;
using System.Linq;
using CupCakeWpf.UI.Models;
using CupCakeWpf.UI.Services.Interfaces;

namespace CupCakeWpf.UI.Services
{
    public class ItemService : IItemService
    {
        private List<Item> _items;

        public ItemService()
        {
            _items = GetItems();
        }

        private List<Item> GetItems()
        {
            return new List<Item>()
            {
                new Item(){ Id = 1, Category = "Category1", IsActive = true, Name ="name1", Price =100},
                new Item(){ Id = 2, Category = "Category2", IsActive = false, Name ="name2", Price =1600},
                new Item(){ Id = 3, Category = "Category3", IsActive = true, Name ="name3", Price =400},
                new Item(){ Id = 4, Category = "Category4", IsActive = false, Name ="name4", Price =1050},
                new Item(){ Id = 5, Category = "Category5", IsActive = true, Name ="name5", Price =140},
            };
        }

        public void Create(Item item)
        {
            _items.Add(item);
        }

        public void Delete(int id)
        {
            var item = _items.Single(s => s.Id == id);
            _items.Remove(item);
        }

        public Item Single(int id)
        {
            return _items.Single(s => s.Id == id);
        }

        public List<Item> ToList()
        {
            return _items;
        }

        public void Update(Item item)
        {
            var itemUpdate = _items.Single(s => s.Id == item.Id);
            _items.Remove(itemUpdate);
            _items.Add(item);
        }
    }
}
