using CupCakeWpf.UI.ViewModels.Interfaces;

namespace CupCakeWpf.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(ILoginViewModel loginViewModel, IInvoiceEditorViewModel invoiceEditorViewModel, IItemsViewModel itemsViewModel)
        {
            LoginViewModel = loginViewModel;
            InvoiceEditorViewModel = invoiceEditorViewModel;
            ItemsViewModel = itemsViewModel;

        }
        public ILoginViewModel LoginViewModel { get; }
        public IInvoiceEditorViewModel InvoiceEditorViewModel { get; }
        public IItemsViewModel ItemsViewModel { get; }

    }
}
