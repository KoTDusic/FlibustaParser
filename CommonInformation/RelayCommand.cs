﻿using System;
using System.Windows.Input;

namespace CommonInformation
{
    class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;
        /// <summary>
        /// Constructer takes Execute events to register in CommandManager.
        /// </summary>
        /// <param name="execute">Execute method as action.</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
            if (null == execute)
            {
                throw new NotImplementedException("Not implemented");
            }
            _execute = execute;
        }
        /// <summary>
        /// Constructer takes Execute and CanExcecute events to register in CommandManager.
        /// </summary>
        /// <param name="execute">Execute method as action.</param>
        /// <param name="canExecute">CanExecute method as return bool type.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (null == execute)
            {
                _execute = null;
                throw new NotImplementedException("Not implemented");
            }
            _execute = execute;
            _canExecute = canExecute;
        }
        /// <summary>
        /// Can Executed Changed Event
        /// </summary>
        public event EventHandler CanExecuteChanged
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
        /// <summary>
        /// Execute method.
        /// </summary>
        /// <param name="parameter">Method parameter.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
        /// <summary>
        /// CanExecute method.
        /// </summary>
        /// <param name="parameter">Method parameter.</param>
        /// <returns>Return true if can execute.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }
        /// <summary>
        /// InvalidateCanExecute method will initiate validation of the Command.
        /// </summary>
        private void InvalidateCanExecute()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }

}
