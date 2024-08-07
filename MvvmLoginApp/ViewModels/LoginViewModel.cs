using System.ComponentModel;
using System.Windows.Input;
using System.Windows;
using MvvmLoginApp.Views;

namespace MvvmLoginApp.ViewModels
{
	public class LoginViewModel : INotifyPropertyChanged
	{
		private string _username;
		public string Username
		{
			get => _username;
			set
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
			}
		}

		private string _password;
		public string Password
		{
			get => _password;
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
			}
		}

		public ICommand LoginCommand { get; }

		public LoginViewModel()
		{
			LoginCommand = new RelayCommand(Login);
		}

		private void Login(object parameter)
		{
			if (Username == "asdf" && Password == "123456")
			{
				// 登錄成功，切換到Top畫面
				var mainViewModel = Application.Current.MainWindow.DataContext as MainViewModel;
				if (mainViewModel != null)
				{
					mainViewModel.CurrentView = new TopView();
				}
			}
			else
			{
				MessageBox.Show("用戶名或密碼錯誤！", "登錄失敗", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}