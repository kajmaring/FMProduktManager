using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repositories
{
    public interface IArtikelRepository : IRepository<TArtikel>
    {
        Task<TArtikel> GetArtikelByIdAsync(int id);
        Task<List<TArtikel>> GetAllArtikelAsync();
        Task<List<TArtikel>> GetAllVaterArtikelAsync();

    }
}
