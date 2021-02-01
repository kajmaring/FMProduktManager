using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UI.WPF.ViewModels;

namespace UI.WPF.State.Navigators
{
    public enum ViewType
    {
        Products,
        ProductVariations
    }
    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
