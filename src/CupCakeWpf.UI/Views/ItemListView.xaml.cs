using CupCakeWpf.UI.Models;
using CupCakeWpf.UI.Services;
using CupCakeWpf.UI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CupCakeWpf.UI.Views
{
    /// <summary>
    /// Interaction logic for ItemListView.xaml
    /// </summary>
    public partial class ItemListView : UserControl
    {
        private IItemService _itemService;
        public ItemListView()
        {
            InitializeComponent();
            _itemService = new ItemService();
            Items = new ObservableCollection<Item>();
            var items = _itemService.ToList();
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        public ObservableCollection<Item> Items { get; set; }


    }
}
