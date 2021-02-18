using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.DBContext;
using DAL.Models;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly WaWiContext _dbContext;

        public ProductService(WaWiContext dBContext)
        {
            this._dbContext = dBContext;
        }

        public async Task<List<Domain.Models.ProductDTO>> GetAllProductsAsync()
        {
            try
            {
                var products = await (from artikel in _dbContext.TArtikel
                                      join beschreibung in _dbContext.TArtikelBeschreibung on artikel.KArtikel equals beschreibung.KArtikel
                                      orderby beschreibung.CName
                                      select new Domain.Models.ProductDTO()
                                      {
                                          ArtNumber = artikel.CArtNr,
                                          Name = beschreibung.CName
                                      }).ToListAsync();

                return products;
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        //public async Task<List<Product>> GetAllProductFathers()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public async Task<Product> GetProductByArtNoAsync(string artNo)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public async Task<Product> GetProductByName(string name)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
