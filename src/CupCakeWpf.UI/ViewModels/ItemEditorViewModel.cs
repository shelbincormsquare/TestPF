using CupCakeWpf.UI.Services;
using CupCakeWpf.UI.ViewModels.Interfaces;

namespace CupCakeWpf.UI.ViewModels
{
    public class ItemEditorViewModel : ViewModelBase, IItemEditorViewModel
    {
        //Name, Cat, Status, Date, Price
        private IItemRepository _itemRepository;

        public ItemEditorViewModel(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
           var djs =  itemRepository.GetItem(1);
            Name = djs.Name;
            Category = djs.Description;
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged(); }
        }

    }
}
