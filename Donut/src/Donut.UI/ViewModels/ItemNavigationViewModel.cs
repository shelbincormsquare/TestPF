using Donut.Core.Interfaces.Repositories;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Donut.UI.ViewModels
{
    public class ItemNavigationViewModel : ViewModelBase, IItemNavigationViewModel
    {
        private IUnitOfWork _unitOfWork;
        public ObservableCollection<NavigationItemViewModel> Items { get; }

        public ItemNavigationViewModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Items = new ObservableCollection<NavigationItemViewModel>();
        }

        public async Task LoadAsync()
        {
            Items.Clear();
            var items = await _unitOfWork.Items.ToListAsync();
            foreach (var item in items)
            {
                Items.Add(new NavigationItemViewModel(item.Id, item.Name));
            }
        }
    }
}
