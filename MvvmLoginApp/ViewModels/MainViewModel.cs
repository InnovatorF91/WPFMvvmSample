using System.ComponentModel;
using System.Windows.Controls;
using MvvmLoginApp.Views;

namespace MvvmLoginApp.ViewModels
{
	public class MainViewModel : INotifyPropertyChanged
	{
		private UserControl _currentView;
		public UserControl CurrentView
		{
			get => _currentView;
			set
			{
				_currentView = value;
				OnPropertyChanged(nameof(CurrentView));
			}
		}

		public MainViewModel()
		{
			// 初始化時顯示登錄畫面
			CurrentView = new LoginView();
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}