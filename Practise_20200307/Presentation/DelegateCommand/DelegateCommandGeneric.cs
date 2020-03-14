using System;
using System.Windows.Input;

namespace Presentation.DelegateCommand
{
    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> execute;
        private readonly Func<T, bool> canExecute;

        public DelegateCommand(Action<T> execute) : this(execute, null)
        {
        }

        public DelegateCommand(Action<T> execute, Func<T, bool> canExecute)
        {
            if (execute == null) throw new ArgumentNullException(nameof(execute));

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute?.Invoke((T)parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            execute((T)parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}