using Donut.Core.Entites;
using Donut.Core.Interfaces.Repositories;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Donut.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IUnitOfWork _unitOfWork;

        public ObservableCollection<Item> Items { get; set; }

        //public MainViewModel(IItemsViewModel itemsViewModel)
        //{
        //    ItemsViewModel = itemsViewModel;
        //}
        //public IItemsViewModel ItemsViewModel { get; }

        public MainViewModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            ProcessDate = "dsd";
            //LoadAsync();
        }

        private string _processDate;
        public string ProcessDate
        {
            get { return _processDate; }

            set
            {
                _processDate = value;
                OnPropertyChanged("ProcessDate");
            }

        }

        public async Task LoadAsync()
        {
            Items = new ObservableCollection<Item>();
            var items = await _unitOfWork.Items.ToListAsync();
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
