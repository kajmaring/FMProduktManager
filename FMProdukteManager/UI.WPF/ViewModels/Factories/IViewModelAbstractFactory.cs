using System;
using System.Collections.Generic;
using System.Text;
using UI.WPF.State.Navigators;

namespace UI.WPF.ViewModels.Factories
{
    public interface IViewModelAbstractFactory
    {
        BaseViewModel CreateViewModel(ViewType viewType);
    }
}
