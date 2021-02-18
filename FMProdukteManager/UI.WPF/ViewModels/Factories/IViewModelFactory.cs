using System;
using System.Collections.Generic;
using System.Text;

namespace UI.WPF.ViewModels.Factories
{
    public interface IViewModelFactory<T> where T : BaseViewModel
    {
        T CreateViewModel();
    }
}
