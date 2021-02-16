using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace Services
{
    public interface IArtikelService
    {
        Task<List<TArtikel>> GetAllArtikelAsync();
        Task<TArtikel> GetProductByIdAsync(int id);
        Task<List<TArtikel>> GetAllVaterArtikelAsync();
    }
}
