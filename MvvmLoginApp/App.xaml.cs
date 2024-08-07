﻿using System.Windows;

namespace MvvmLoginApp
{
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			MainWindow = new MainWindow();
			MainWindow.Show();
		}
	}
}