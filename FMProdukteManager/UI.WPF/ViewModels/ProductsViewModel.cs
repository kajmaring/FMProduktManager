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
        private ProductDTO _selectedProduct;
        internal CollectionViewSource ProductsViewSource { get; set; } = new CollectionViewSource();

        public ProductsViewModel(IProductService productService)
        {
            _productService = productService;
            ProductsViewSource.Filter += ProductsViewSource_Filter;

            LoadProducts();
        }

        private async void LoadProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            if (products != null)
            {
                _products = new ObservableCollection<ProductDTO>(products);
                ProductsViewSource.Source = _products;
                OnPropertyChanged(nameof(ProductsView));
            }
        }

        public ICollectionView ProductsView
        {
            get { return ProductsViewSource.View; }
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
                if (p.Name.ToLower().Contains(_productsFilter.ToLower()) || p.ArtNumber.ToLower().Contains(_productsFilter.ToLower()))
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

        public ProductDTO SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }


    }
}
