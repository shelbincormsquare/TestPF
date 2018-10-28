using CupCakeWpf.UI.ViewModels.Interfaces;

namespace CupCakeWpf.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(ILoginViewModel loginViewModel)
        {
            LoginViewModel = loginViewModel;
        }
        public ILoginViewModel LoginViewModel { get; }
    }
}
