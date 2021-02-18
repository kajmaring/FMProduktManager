using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using System.Linq;
using DAL.DBContext;

namespace DAL.Repositories
{
    public class BildRepository : Repository<TBild>, IBildRepository
    {
        public BildRepository(WaWiContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<TBild>> GetAllBilderAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<TBild> GetBildByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.KBild == id);
        }

    }
}
