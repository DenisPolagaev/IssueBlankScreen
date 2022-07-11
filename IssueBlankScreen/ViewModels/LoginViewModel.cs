using IssueBlankScreen;
using System.Windows.Input;

namespace IssueBlankScreen.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {

        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
            }
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get => _loginCommand ??= new Command(async () =>
            {
                await MainThread.InvokeOnMainThreadAsync(() =>
                {
                    Application.Current.MainPage = new MainPage() { BindingContext = new MainViewModel()};
                });
            });
        }
    }
}
