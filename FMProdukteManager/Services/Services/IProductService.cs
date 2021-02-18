using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProductsAsync();
        //Task<List<Product>> GetAllProductFathers();

        //Task<Product> GetProductByArtNoAsync(string artNo);
        //Task<Product> GetProductByName(string name);
        
    }
}
