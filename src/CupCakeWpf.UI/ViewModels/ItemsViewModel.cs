using CupCakeWpf.UI.ViewModels.Interfaces;

namespace CupCakeWpf.UI.ViewModels
{
    public class ItemsViewModel : ViewModelBase, IItemsViewModel
    {
        public ItemsViewModel(IItemEditorViewModel itemEditorViewModel, IItemListViewModel itemListViewModel)
        {
            ItemEditorViewModel = itemEditorViewModel;
            ItemListViewModel = itemListViewModel;
        }

        public IItemEditorViewModel ItemEditorViewModel { get; }
        public IItemListViewModel ItemListViewModel { get; }
    }
}
