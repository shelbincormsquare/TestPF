using CupCakeWpf.UI.ViewModels.Interfaces;

namespace CupCakeWpf.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(ILoginViewModel loginViewModel, IInvoiceEditorViewModel invoiceEditorViewModel)
        {
            LoginViewModel = loginViewModel;
            InvoiceEditorViewModel = invoiceEditorViewModel;
        }
        public ILoginViewModel LoginViewModel { get; }
        public IInvoiceEditorViewModel InvoiceEditorViewModel { get; }
    }
}
