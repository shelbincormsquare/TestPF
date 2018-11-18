using Donut.Core.Entites;
using Donut.Core.Interfaces.Repositories;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Donut.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IItemNavigationViewModel itemNavigationViewModel)
        {
            ItemNavigationViewModel = itemNavigationViewModel;
        }

        public IItemNavigationViewModel  ItemNavigationViewModel { get; }

        public async Task LoadAsync()
        {
            await ItemNavigationViewModel.LoadAsync();
        }
    }
}
