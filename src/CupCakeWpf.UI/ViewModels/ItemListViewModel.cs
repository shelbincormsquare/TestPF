using CupCakeWpf.UI.Models;
using CupCakeWpf.UI.Services.Interfaces;
using CupCakeWpf.UI.ViewModels.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CupCakeWpf.UI.ViewModels
{
    public class ItemListViewModel : ViewModelBase, IItemListViewModel
    {
        private IItemService _itemService;
        public ObservableCollection<Item> Items { get; set; }


        public ItemListViewModel(IItemService itemService)
        {
            _itemService = itemService;
            Items = new ObservableCollection<Item>();
            var items = _itemService.ToList();
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
