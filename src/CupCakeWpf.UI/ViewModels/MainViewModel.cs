using CupCakeWpf.UI.ViewModels.Interfaces;

namespace CupCakeWpf.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IItemsViewModel itemsViewModel)
        {
            ItemsViewModel = itemsViewModel;
        }
        public IItemsViewModel ItemsViewModel { get; }
    }
}
