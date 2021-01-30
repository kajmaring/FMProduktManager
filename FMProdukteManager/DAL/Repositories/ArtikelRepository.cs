using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using System.Linq;

namespace DAL.Repositories
{
    public class ArtikelRepository : Repository<Artikel>, IArtikelRepository
    {
        public ArtikelRepository(EazybusinessContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Artikel>> GetAllArtikelAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Artikel> GetArtikelByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.KArtikel == id);
        }

        public async Task<List<Artikel>> GetAllVaterArtikelAsync()
        {
            return await dbContext.TArtikel.Where(x => x.NIstVater == 1).ToListAsync();
        }

    }
}
