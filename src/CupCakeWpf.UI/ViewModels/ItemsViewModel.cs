using CupCakeWpf.UI.ViewModels.Interfaces;

namespace CupCakeWpf.UI.ViewModels
{
    public class ItemsViewModel : ViewModelBase, IItemsViewModel
    {
        public IItemListViewModel ItemListViewModel;

        //IItemListViewModel
        public ItemsViewModel(IItemListViewModel itemListViewModel)
        {
            ItemListViewModel = itemListViewModel;
        }
    }
}
