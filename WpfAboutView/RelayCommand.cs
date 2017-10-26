using System;
using System.Windows.Input;

namespace WpfAboutView
{
    internal class RelayCommand<T> : ICommand
    {
        private readonly Func<T, bool> _canExecuteMethod;
        private readonly Action<T> _executeMethod;

        public RelayCommand(Action<T> executeMethod)
        {
            _executeMethod = executeMethod;
        }

        public RelayCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        bool ICommand.CanExecute(object parameter)
        {
            if (_canExecuteMethod != null)
            {
                return _canExecuteMethod((T)parameter);
            }
            if (_executeMethod != null)
            {
                return true;
            }
            return false;
        }

        void ICommand.Execute(object parameter)
        {
            _executeMethod?.Invoke((T)parameter);
        }
    }
}