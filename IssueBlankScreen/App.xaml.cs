
using IssueBlankScreen.ViewModels;

namespace IssueBlankScreen;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginPage() { BindingContext = new LoginViewModel()});
	}
}
