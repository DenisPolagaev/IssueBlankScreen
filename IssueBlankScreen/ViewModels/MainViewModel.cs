using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IssueBlankScreen.ViewModels
{
    public class MainViewModel
    {
        private ICommand _logoutCommand;
        public ICommand LogoutCommand
        {
            get => _logoutCommand ??= new Command(async () =>
            {
                await MainThread.InvokeOnMainThreadAsync(() =>
                {
                    Application.Current.MainPage = new LoginPage() { BindingContext = new LoginViewModel() };
                });
            });
        }
    }
}
