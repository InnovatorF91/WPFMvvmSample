﻿using System;
using System.Windows.Input;

namespace MvvmLoginApp
{
	public class RelayCommand : ICommand
	{
		private readonly Action<object> _execute;

		public RelayCommand(Action<object> execute)
		{
			_execute = execute ?? throw new ArgumentNullException(nameof(execute));
		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public bool CanExecute(object parameter) => true;

		public void Execute(object parameter) => _execute(parameter);
	}
}