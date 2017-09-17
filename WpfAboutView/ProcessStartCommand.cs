using System;
using System.Diagnostics;
using System.Windows.Input;

namespace WpfAboutView
{
    internal class ProcessStartCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            Process.Start(((Uri)parameter).AbsolutePath);
        }
    }
}