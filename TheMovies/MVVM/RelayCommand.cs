﻿using System.Windows.Input;

namespace TheMovies.MVVM
{
    internal class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        bool ICommand.CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        void ICommand.Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
