using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UI.WPF.State.Navigators;
using UI.WPF.ViewModels;

namespace UI.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Products:
                        _navigator.CurrentViewModel = new ProductsViewModel();
                        break;
                    case ViewType.ProductVariations:
                        _navigator.CurrentViewModel = new ProductVariationsViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}