using CupCakeWpf.UI.ViewModels.Interfaces;
using Prism.Commands;
using System;
using System.Windows;
using System.Windows.Input;

namespace CupCakeWpf.UI.ViewModels
{
    public class LoginViewModel : ViewModelBase, ILoginViewModel
    {
        public ICommand LoginCommand { get; }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(OnLoginExecute, OnLoginCanExecute);
        }

        private bool OnLoginCanExecute()
        {
            return true;
        }

        private void OnLoginExecute()
        {
            MessageBox.Show(Email + "  " + Password);
        }
    }
}
