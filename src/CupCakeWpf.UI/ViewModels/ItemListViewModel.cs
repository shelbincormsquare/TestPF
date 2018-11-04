using CupCakeWpf.UI.Services;
using CupCakeWpf.UI.ViewModels.Interfaces;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace CupCakeWpf.UI.ViewModels
{
    public class ItemListViewModel : ViewModelBase, IItemListViewModel
    {
        private IItemRepository _itemRepository;

        public ItemListViewModel(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            Items = _itemRepository.GetAllItems();
        }

        private DataGridCellInfo _cellInfo;
        public DataGridCellInfo CellInfo
        {
            get { return _cellInfo; }
            set
            {
                _cellInfo = value;
                OnPropertyChanged("CellInfo");
                MessageBox.Show(string.Format("Column: {0}",
                                _cellInfo.Column.DisplayIndex != null ? _cellInfo.Column.DisplayIndex.ToString() : "Index out of range!"));
            }
        }


        public List<Item> Items { get; set; }
    }
}
