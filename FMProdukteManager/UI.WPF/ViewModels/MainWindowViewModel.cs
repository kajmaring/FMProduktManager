using System;
using System.Collections.Generic;
using System.Text;
using UI.WPF.State.Navigators;

namespace UI.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public INavigator Navigator { get; set; } = new Navigator();

        public MainWindowViewModel()
        {
            //Set Startup View:
            Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Products);
        }
    }
}
