using System;
using System.Collections.Generic;
using System.Text;
using UI.WPF.State.Navigators;

namespace UI.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public INavigator Navigator { get; set; }

        public MainWindowViewModel(INavigator navigator)
        {
            this.Navigator = navigator;

            //Set Startup View:
            Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Products);
        }
    }
}
