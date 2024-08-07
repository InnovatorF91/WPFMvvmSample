using System.Windows;
using MvvmLoginApp.ViewModels;

namespace MvvmLoginApp
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
		}
	}
}