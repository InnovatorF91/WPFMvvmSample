using System.Windows.Controls;

namespace MvvmLoginApp.Views
{
	public partial class LoginView : UserControl
	{
		public LoginView()
		{
			InitializeComponent();
			DataContext = new ViewModels.LoginViewModel();

			PasswordBox.PasswordChanged += (s, e) =>
			{
				if (DataContext is ViewModels.LoginViewModel viewModel)
				{
					viewModel.Password = PasswordBox.Password;
				}
			};
		}
	}
}