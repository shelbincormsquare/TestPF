using Donut.Core.Entites;
using Donut.Core.Interfaces.Repositories;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Donut.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public IItemNavigationViewModel NavigationViewModel { get; }

        public MainViewModel(IItemNavigationViewModel itemNavigationViewModel)
        {
            NavigationViewModel = itemNavigationViewModel;
        }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }
    }
}
