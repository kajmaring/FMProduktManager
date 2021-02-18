using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UI.WPF.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        private readonly IProductService _productService;
        private string _productsFilter;
        private ObservableCollection<ProductDTO> _products;
        internal CollectionViewSource ProductsViewSource { get; set; } = new CollectionViewSource();

        public ProductsViewModel(IProductService productService)
        {
            _productService = productService;

            ProductsViewSource.Filter += ProductsViewSource_Filter;

        }
        public ICollectionView ProductsView
        {
            get { return ProductsViewSource.View; }
        }

        public static ProductsViewModel LoadProductsViewModel(IProductService productService)
        {
            ProductsViewModel productsViewModel = new ProductsViewModel(productService);
            productsViewModel.LoadProducts();
            return productsViewModel;
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProductsAsync().ContinueWith(task =>
            {
                if(task.Exception == null)
                {
                    _products = new ObservableCollection<ProductDTO>(task.Result); 
                }
            });
        }

        private void ProductsViewSource_Filter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_productsFilter))
            {
                //no filter when no search text is entered
                e.Accepted = true;
            }
            else
            {
                ProductDTO p = (ProductDTO)e.Item;
                if (p.Name.StartsWith(_productsFilter) || p.ArtNumber.StartsWith(_productsFilter))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }
        public string ProductsFilter
        {
            get
            {
                return _productsFilter;
            }
            set
            {
                if (value != _productsFilter)
                {
                    _productsFilter = value;
                    OnPropertyChanged(nameof(ProductsFilter));
                    ProductsView.Refresh();      
                }
            }
        }

    }
}
