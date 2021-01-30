using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repositories
{
    public interface IArtikelRepository : IRepository<Artikel>
    {
        Task<Artikel> GetArtikelByIdAsync(int id);
        Task<List<Artikel>> GetAllArtikelAsync();
        Task<List<Artikel>> GetAllVaterArtikelAsync();

    }
}
