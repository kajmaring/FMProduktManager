using System;
using System.Collections.Generic;
using System.Text;
using UI.WPF.State.Navigators;

namespace UI.WPF.ViewModels.Factories
{
    public class ViewModelAbstractFactory : IViewModelAbstractFactory
    {
        private readonly IViewModelFactory<ProductsViewModel> _productsViewModelFactory;
        private readonly IViewModelFactory<ProductVariationsViewModel> _productVariationsViewModelFactory;

        public ViewModelAbstractFactory(IViewModelFactory<ProductsViewModel> productsViewModelFactory,
                                        IViewModelFactory<ProductVariationsViewModel> productVariationsViewModelFactory)
        {
            _productsViewModelFactory = productsViewModelFactory;
            _productVariationsViewModelFactory = productVariationsViewModelFactory;
        }

        public BaseViewModel CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Products:
                    return _productsViewModelFactory.CreateViewModel();
                case ViewType.ProductVariations:
                    return _productVariationsViewModelFactory.CreateViewModel();
                default:
                    throw new ArgumentException("Dieser ViewType hat kein ViewModel.", "viewType");
            }
        }
    }
}
