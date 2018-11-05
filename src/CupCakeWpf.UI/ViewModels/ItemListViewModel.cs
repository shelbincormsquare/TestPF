using CupCakeWpf.UI.Models;
using CupCakeWpf.UI.Services.Interfaces;
using CupCakeWpf.UI.ViewModels.Interfaces;
using System.Collections.Generic;

namespace CupCakeWpf.UI.ViewModels
{
    public class ItemListViewModel : IItemListViewModel
    {
        private IItemService _itemService;
        public List<Item> Items;

        public ItemListViewModel(IItemService itemService)
        {
            _itemService = itemService;
            Items = _itemService.ToList();
        }
    }
}
