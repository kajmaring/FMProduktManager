using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace Services
{
    public interface IArtikelService
    {
        Task<List<Artikel>> GetAllArtikelAsync();
        Task<Artikel> GetProductByIdAsync(int id);
        Task<List<Artikel>> GetAllVaterArtikelAsync();
    }
}
