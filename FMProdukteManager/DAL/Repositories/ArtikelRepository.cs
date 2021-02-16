using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using System.Linq;
using DAL.DBContext;

namespace DAL.Repositories
{
    public class ArtikelRepository : Repository<TArtikel>, IArtikelRepository
    {
        public ArtikelRepository(WaWiContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<TArtikel>> GetAllArtikelAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<TArtikel> GetArtikelByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.KArtikel == id);
        }

        public async Task<List<TArtikel>> GetAllVaterArtikelAsync()
        {
            return await dbContext.TArtikel.Where(x => x.NIstVater == 1).ToListAsync();
        }

    }
}
