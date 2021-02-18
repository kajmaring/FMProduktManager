using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.WPF.ViewModels.Factories
{
    public class ProductsViewModelFactory : IViewModelFactory<ProductsViewModel>
    {
        private readonly IProductService _productService;

        public ProductsViewModelFactory(IProductService productService)
        {
            _productService = productService;
        }

        public ProductsViewModel CreateViewModel()
        {
            return new ProductsViewModel(_productService);
        }
    }
}
