using CupCakeWpf.UI.ViewModels;
using MahApps.Metro.Controls;

namespace CupCakeWpf.UI
{
    public partial class MainWindow : MetroWindow
    {
        private MainViewModel _viewModel;
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
        }
    }
}
