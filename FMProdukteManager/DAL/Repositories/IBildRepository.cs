using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repositories
{
    public interface IBildRepository : IRepository<TBild>
    {
        Task<TBild> GetBildByIdAsync(int id);
        Task<List<TBild>> GetAllBilderAsync();

    }
}
