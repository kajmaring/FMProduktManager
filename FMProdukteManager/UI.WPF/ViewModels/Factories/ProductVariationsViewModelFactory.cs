using System;
using System.Collections.Generic;
using System.Text;

namespace UI.WPF.ViewModels.Factories
{
    public class ProductVariationsViewModelFactory : IViewModelFactory<ProductVariationsViewModel>
    {
        public ProductVariationsViewModel CreateViewModel()
        {
            return new ProductVariationsViewModel();
        }
    }
}
