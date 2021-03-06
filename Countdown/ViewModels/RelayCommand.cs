﻿using System;
using System.Windows.Input;

namespace Countdown.ViewModels
{
    internal sealed class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        // when hooked up by wpf add our can execute method to the command 
        // managers event handler instead of this so that the state is 
        // updated when the command manger sees fit
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public bool CanExecute(object parameter)
        {
            return (canExecute is null) || canExecute(parameter);
        }


        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
